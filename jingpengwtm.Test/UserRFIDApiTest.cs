using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using jingpengwtm.Controllers;
using jingpengwtm.api.ViewModels.UserRFIDVMs;
using jingpengwtm.Models;
using jingpengwtm;

namespace jingpengwtm.Test
{
    [TestClass]
    public class UserRFIDApiTest
    {
        private UserRFIDApiController _controller;
        private string _seed;

        public UserRFIDApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<UserRFIDApiController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            string rv = _controller.Search(new UserRFIDApiSearcher());
            Assert.IsTrue(string.IsNullOrEmpty(rv)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            UserRFIDApiVM vm = _controller.CreateVM<UserRFIDApiVM>();
            UserRFID v = new UserRFID();
            
            v.ID = "z5EhQHV";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserRFID>().FirstOrDefault();
                
                Assert.AreEqual(data.ID, "z5EhQHV");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            UserRFID v = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = "z5EhQHV";
                context.Set<UserRFID>().Add(v);
                context.SaveChanges();
            }

            UserRFIDApiVM vm = _controller.CreateVM<UserRFIDApiVM>();
            var oldID = v.ID;
            v = new UserRFID();
            v.ID = oldID;
       		
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserRFID>().FirstOrDefault();
 				
            }

        }

		[TestMethod]
        public void GetTest()
        {
            UserRFID v = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = "z5EhQHV";
                context.Set<UserRFID>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            UserRFID v1 = new UserRFID();
            UserRFID v2 = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = "z5EhQHV";
                context.Set<UserRFID>().Add(v1);
                context.Set<UserRFID>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<UserRFID>().Count(), 0);
            }

            rv = _controller.BatchDelete(new string[] {});
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
