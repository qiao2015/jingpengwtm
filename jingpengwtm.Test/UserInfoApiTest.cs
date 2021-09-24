using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using jingpengwtm.Controllers;
using jingpengwtm.userInfoArea.ViewModels.UserInfoVMs;
using jingpengwtm.Models;
using jingpengwtm;

namespace jingpengwtm.Test
{
    [TestClass]
    public class UserInfoApiTest
    {
        private UserInfoApiController _controller;
        private string _seed;

        public UserInfoApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<UserInfoApiController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            string rv = _controller.Search(new UserInfoApiSearcher());
            Assert.IsTrue(string.IsNullOrEmpty(rv)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            UserInfoApiVM vm = _controller.CreateVM<UserInfoApiVM>();
            UserInfo v = new UserInfo();
            
            v.ID = "UllWaOVG";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserInfo>().FirstOrDefault();
                
                Assert.AreEqual(data.ID, "UllWaOVG");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            UserInfo v = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = "UllWaOVG";
                context.Set<UserInfo>().Add(v);
                context.SaveChanges();
            }

            UserInfoApiVM vm = _controller.CreateVM<UserInfoApiVM>();
            var oldID = v.ID;
            v = new UserInfo();
            v.ID = oldID;
       		
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserInfo>().FirstOrDefault();
 				
            }

        }

		[TestMethod]
        public void GetTest()
        {
            UserInfo v = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = "UllWaOVG";
                context.Set<UserInfo>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            UserInfo v1 = new UserInfo();
            UserInfo v2 = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = "UllWaOVG";
                context.Set<UserInfo>().Add(v1);
                context.Set<UserInfo>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<UserInfo>().Count(), 0);
            }

            rv = _controller.BatchDelete(new string[] {});
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
