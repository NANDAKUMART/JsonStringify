using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace JsonStringify
{
    public class Converter
    {
        public static string StringifyJson(Object rootObj)
        {
            var stringObj = ConvertObjToJsonString(rootObj.GetType(), rootObj);
            stringObj = stringObj.Trim().Replace(" ", "");

            while (stringObj.IndexOf(",,") > 0)
                stringObj = stringObj.Replace(",,", ",");

            return stringObj;
        }

        public static string ConvertObjToJsonString(Type rootType, Object rootObj)
        {
            var stringifiedJson = "";
            var propList = rootType.GetProperties();

            foreach (var prop in propList)
            {
                if (!String.IsNullOrEmpty(stringifiedJson))
                    stringifiedJson += ",";

                if (prop.PropertyType.IsPrimitive || prop.PropertyType.Name.ToLower() == "string")
                {
                    var targetVal = prop.GetValue(rootObj, null);
                    if (targetVal != null)
                    {
                        var currentStr = "";
                        if (prop.PropertyType.Name.ToLower() == "string")
                        {
                            currentStr = "\"" + prop.Name + "\":\"" + targetVal + "\""; ;
                        }
                        else
                        {
                            currentStr = "\"" + prop.Name + "\":" + targetVal;
                        }
                        stringifiedJson += currentStr;
                    }
                }
                else if (prop.PropertyType.IsArray)
                {
                    var underlyingType = prop.PropertyType.GetElementType();
                    var targetObjValue = prop.GetValue(rootObj, null);
                    var typedList = (targetObjValue as IEnumerable);
                    var collectionStringfy = "";

                    if (typedList != null)
                    {
                        if (underlyingType.IsPrimitive || underlyingType.Name.ToLower() == "string")
                        {
                            foreach (var val in typedList)
                            {
                                if (collectionStringfy.Length > 0)
                                    collectionStringfy += ",";

                                if (underlyingType.Name.ToLower() == "string")
                                {
                                    collectionStringfy += "\"" + val + "\"";
                                }
                                else
                                {
                                    collectionStringfy += val;
                                }
                            }
                        }
                        else
                        {
                            foreach (var obj in typedList)
                            {
                                if (collectionStringfy.Length > 0)
                                    collectionStringfy += ",";

                                var stringfiedObj = ConvertObjToJsonString(underlyingType, obj);
                                collectionStringfy += stringfiedObj;
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(collectionStringfy))
                            stringifiedJson += "\"" + prop.Name + "\":[" + collectionStringfy + "]";

                    }
                }
                else if (prop.PropertyType.IsGenericType)
                {
                    var underlyingType = prop.PropertyType.GetGenericArguments()[0];
                    if (underlyingType.Name != prop.PropertyType.Name)  //Self recursion here
                    {
                        var targetObjValue = prop.GetValue(rootObj, null);
                        var typedList = (targetObjValue as IEnumerable);
                        //var collectionLength = prop.PropertyType.GetProperty("Count").GetValue(targetObjValue, null);

                        if (typedList != null)
                        {
                            var collectionStringfy = "";
                            foreach (var obj in typedList)
                            {
                                if (collectionStringfy.Length > 0)
                                    collectionStringfy += ",";

                                var stringfiedObj = ConvertObjToJsonString(underlyingType, obj);
                                collectionStringfy += stringfiedObj;
                            }
                            stringifiedJson += "\"" + prop.Name + "\":[" + collectionStringfy + "]";
                        }
                    }

                }
                else  //if it is single obj                    
                {
                    var targetObjValue = prop.GetValue(rootObj, null);

                    if (targetObjValue != null) //&& rootType.Name != prop.PropertyType.Name)  //Self recursion here
                    {
                        var stringfiedObj = ConvertObjToJsonString(prop.PropertyType, targetObjValue);
                        if (stringfiedObj != null)
                            stringifiedJson += "\"" + prop.Name + "\":" + stringfiedObj;
                    }
                }

            }

            return "{" + stringifiedJson + "}";
        }
    }
}
