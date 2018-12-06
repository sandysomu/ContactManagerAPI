using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace DynamoDb.Libs.DynamoDb
{
    public interface IDynamoDbExamples
    {
        void CreateDynamoDbTable();
    }


   public class DynamoDbExamples : IDynamoDbExamples
   {
       private readonly IAmazonDynamoDB _dynamoDbClient;
        private readonly string tableName = "TempTable";

        public DynamoDbExamples(IAmazonDynamoDB dynamoDbCleint)
       {
           _dynamoDbClient = dynamoDbCleint;
       }


       public void CreateDynamoDbTable()
       {
           try
           {
               CreateTempTable();
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }

       }

       private void CreateTempTable()
       {
           var request = new CreateTableRequest
           {
               AttributeDefinitions = new List<AttributeDefinition>
               {
                   new AttributeDefinition
                   {
                       AttributeName = "RefNumber",
                       AttributeType = "N"
                   },

                   new AttributeDefinition
                   {
                       AttributeName = "FirstName",
                       AttributeType = "string"
                   }
               },

               KeySchema = new List<KeySchemaElement>
               {
                   new KeySchemaElement
                   {
                       AttributeName = "RefNumber",
                       KeyType = "HASH" // Partition key
                   },
                   new KeySchemaElement
                   {
                       AttributeName = "FirstName",
                       KeyType = "Range" // Sort key
                   }
               },

               //ProvisionedThroughput = new ProvisionedThroughput
               //{
               //    ReadCapacityUnits = 5,
               //    WriteCapacityUnits = 5
               //},

               TableName = tableName

           };

           var response = _dynamoDbClient.CreateTableAsync(request);

           WatiUntillTableIsReady(tableName);

       }

        private void WatiUntillTableIsReady(string tableName)
        {
            string status = null;

            do
            {
                Thread.Sleep(5000);

                try
                {
                    var res = _dynamoDbClient.DescribeTableAsync(new DescribeTableRequest
                    {
                        TableName = tableName
                    });
                    status = res.Result.Table.TableStatus;
                }
                catch (ResourceNotFoundException) { }

            } while (status != "ACTIVE");

            
        }
    }

 
}
