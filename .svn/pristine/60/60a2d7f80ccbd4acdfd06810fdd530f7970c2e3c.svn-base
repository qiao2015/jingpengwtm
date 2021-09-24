using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using jingpengwtm.Controllers;
using jingpengwtm.userRFIDArea.ViewModels.UserRFIDVMs;
using jingpengwtm.Models;
using jingpengwtm;

namespace jingpengwtm.Test
{
    [TestClass]
    public class UserRFIDControllerTest
    {
        private UserRFIDController _controller;
        private string _seed;

        public UserRFIDControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<UserRFIDController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
            string rv2 = _controller.Search(rv.Model as UserRFIDListVM);
            Assert.IsTrue(rv2.Contains("\"Code\":200"));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(UserRFIDVM));

            UserRFIDVM vm = rv.Model as UserRFIDVM;
            UserRFID v = new UserRFID();
			
            v.ID = "1YrKmJL";
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserRFID>().FirstOrDefault();
				
                Assert.AreEqual(data.ID, "1YrKmJL");
            }

        }

        [TestMethod]
        public void EditTest()
        {
            UserRFID v = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = "1YrKmJL";
                context.Set<UserRFID>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(UserRFIDVM));

            UserRFIDVM vm = rv.Model as UserRFIDVM;
            v = new UserRFID();
            v.ID = vm.Entity.ID;
       		
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<UserRFID>().FirstOrDefault();
 				
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            UserRFID v = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = "1YrKmJL";
                context.Set<UserRFID>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(UserRFIDVM));

            UserRFIDVM vm = rv.Model as UserRFIDVM;
            v = new UserRFID();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID.ToString(),null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<UserRFID>().Count(), 0);
            }

        }


        [TestMethod]
        public void DetailsTest()
        {
            UserRFID v = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.ID = "1YrKmJL";
                context.Set<UserRFID>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID.ToString());
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.GetID());
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            UserRFID v1 = new UserRFID();
            UserRFID v2 = new UserRFID();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = "1YrKmJL";
                context.Set<UserRFID>().Add(v1);
                context.Set<UserRFID>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv.Model, typeof(UserRFIDBatchVM));

            UserRFIDBatchVM vm = rv.Model as UserRFIDBatchVM;
            vm.Ids = new string[] { v1.ID.ToString(), v2.ID.ToString() };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<UserRFID>().Count(), 0);
            }
        }


    }
}
