﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DbContexts;
using WebApplication2.Model;
using System.Data.SqlClient;
using System.Data.Sql;


namespace WebApplication2.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly TestContext _testContext;
       private string connectionString;

        //public TestRepository(TestContext TContext)
        //{
        //    _testContext = TContext;
            
        //}
        public TestRepository(string Con)
        {
            connectionString = Con;

        }

        public Test GetTestById(int id)
        {

            Test test = new Test();
            test.Id = 1;
            test.Name = "test1";
            test.description = "testing";

            _testContext.lstTests.Add(test);

            return _testContext.lstTests.Find(id);
        }

        public IEnumerable<Test> GetTests()
        {

        
            //MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection("server=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb;  uid=xxuser; pwd=welcome1;");
            //connection.Open();
            //MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from table1",connection);
            //System.Data.DataSet ds = new System.Data.DataSet();
            //adapter.Fill(ds);
            //connection.Close();

            Test[] tests = new Test[2];
            
             tests[0]=   new Test { Id = 2, Name = "Get1",description="get1 description" };
           tests[1]= new Test { Id = 3, Name = "Get2", description = "get2 description" };

            // string con = "Data Source=mmatc1718.db.11833524.hostedresource.com; Initial catalog=mmatc1718; user id=mmatc1718; password=MADMADmad@1;";


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Acmaster", connectionString);

            System.Data.DataTable dt = new System.Data.DataTable();
            sqlDataAdapter.Fill(dt);

            int count = dt.Rows.Count;



            


            //_testContext.lstTests.Add(test);

            return tests;

           // return _testContext.lstTests.ToList();
        }

       
    }
}
