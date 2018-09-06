using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TestFrameworkLib;
using TestFrameworkLib.beans;

namespace TestFramework
{

    public class MyDataClass
    {

        private static int CalculateDataSetParams(Dictionary<string, object> names, ref int arguments)
        {
            int dataSets;
            foreach (KeyValuePair<String, Object> entry in names)
            {
                String objectName = entry.Key;
                if (objectName.IndexOf('1') == 7)
                {
                    arguments++;
                }
                else
                {
                    break;
                }

            }
            dataSets = names.Count / arguments;
            return dataSets;
        }

        public static IEnumerable AutoAutoAssertion1(String MultipleDataSetName)
        {
            String[] DataSetNames = MultipleDataSetName.Split(',');
            for(int j=0; j < DataSetNames.Length; j++)
            {
                String DataSetName = DataSetNames[j];
                MongoDbConnection mongoDbConnection = new MongoDbConnection();
                ClassDetails classDetails = mongoDbConnection.getClassDetails(DataSetName);
                Dictionary<String, Object> reqNames = mongoDbConnection.getRequestData(DataSetName, "Request");
                Dictionary<String, Object> respNames = mongoDbConnection.getRequestData(DataSetName, "Response");

                int dataSets = 0;
                int arguments = 0;
                dataSets = CalculateDataSetParams(reqNames, ref arguments);

                for (int i = 1; i < dataSets + 1; i++)
                {
                    //TODO create testcases objects using reflection
                    if (arguments == 1)
                    {
                        yield return new TestCaseData(classDetails, reqNames["Request" + i + "1"]).Returns(respNames["Response" + i]);
                    }
                    else if (arguments == 2)
                    {
                        yield return new TestCaseData(classDetails, reqNames["Request" + i + "1"], reqNames["Request" + i + "2"]).Returns(respNames["Response" + i]);
                    }
                    else if (arguments == 3)
                    {
                        yield return new TestCaseData(classDetails, reqNames["Request" + i + "1"], reqNames["Request" + i + "2"], reqNames["Request" + i + "3"]).Returns(respNames["Response" + i]);
                    }
                }
            }
        }


        public static IEnumerable AutoAutoAssertion(String DataSetName)
        {
            MongoDbConnection mongoDbConnection = new MongoDbConnection();
            ClassDetails classDetails = mongoDbConnection.getClassDetails(DataSetName);
            Dictionary<String, Object> reqNames = mongoDbConnection.getRequestData(DataSetName, "Request");
            Dictionary<String, Object> respNames = mongoDbConnection.getRequestData(DataSetName, "Response");

            int dataSets = 0;
            int arguments = 0;
            dataSets = CalculateDataSetParams(reqNames, ref arguments);

            for (int i = 1; i < dataSets + 1; i++)
            {
                //TODO create testcases objects using reflection
                if (arguments == 1)
                {
                    yield return new TestCaseData(classDetails, reqNames["Request" + i + "1"]).Returns(respNames["Response" + i]);
                }
                else if (arguments == 2)
                {
                    yield return new TestCaseData(classDetails, reqNames["Request" + i + "1"], reqNames["Request" + i + "2"]).Returns(respNames["Response" + i]);
                }
                else if (arguments == 3)
                {
                    yield return new TestCaseData(classDetails, reqNames["Request" + i + "1"], reqNames["Request" + i + "2"], reqNames["Request" + i + "3"]).Returns(respNames["Response" + i]);
                }
            }
            
        }
    }
}
