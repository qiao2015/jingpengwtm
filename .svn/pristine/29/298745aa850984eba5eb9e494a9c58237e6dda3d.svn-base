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
    public class UserInfoControllerTest
    {
        private UserInfoController _controller;
        private string _seed;

        public UserInfoControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<UserInfoController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search(rv.Model as UserInfoListVM);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(UserInfoVM));

            UserInfoVM vm = rv.Model as UserInfoVM;
            UserInfo v = new UserInfo();
			
            v.ID = "EkA1Mju5";
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserInfo>().FirstOrDefault();
				
                Assert.AreEqual(data.ID, "EkA1Mju5");
            }

        }

        [TestMethod]
        public void EditTest()
        {
            UserInfo v = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = "EkA1Mju5";
                context.Set<UserInfo>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(UserInfoVM));

            UserInfoVM vm = rv.Model as UserInfoVM;
            v = new UserInfo();
            v.ID = vm.Entity.ID;
       		
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserInfo>().FirstOrDefault();
 				
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            UserInfo v = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = "EkA1Mju5";
                context.Set<UserInfo>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(UserInfoVM));

            UserInfoVM vm = rv.Model as UserInfoVM;
            v = new UserInfo();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<UserInfo>().Count(), 0);
            }

        }


        [TestMethod]
        public void DetailsTest()
        {
            UserInfo v = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.ID = "EkA1Mju5";
                context.Set<UserInfo>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            UserInfo v1 = new UserInfo();
            UserInfo v2 = new UserInfo();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = "EkA1Mju5";
                context.Set<UserInfo>().Add(v1);
                context.Set<UserInfo>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(UserInfoBatchVM));

            UserInfoBatchVM vm = rv.Model as UserInfoBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<UserInfo>().Count(), 0);
            }
        }


    }
}
