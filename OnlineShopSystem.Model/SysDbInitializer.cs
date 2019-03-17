using System;
using System.Collections.Generic;
using System.Data.Entity;
using OnlineShopSystem.Model.Category;
using OnlineShopSystem.Model.User;
using OnlineShopSystem.Security;

namespace OnlineShopSystem.Model
{
    /// <summary>
    /// 数据库初始化类
    /// </summary>
    public class SysDbInitializer : DropCreateDatabaseIfModelChanges<SysContext>
    {
        // 数据库初始化数据
        protected override void Seed(SysContext context)
        {
            #region 管理员账户

            var administrators = new List<Administrator>
            {
                new Administrator
                {
                    Account = "admin001",
                    Password = "123123",
                    DisplayName = "1号管理员",
                    CreateTime = DateTime.Now
                },
                new Administrator
                {
                    Account = "admin002",
                    Password = "123123",
                    DisplayName = "2号管理员",
                    CreateTime = DateTime.Now
                }
            };

            administrators.ForEach(item => context.Administrators.Add(item));

            context.SaveChanges();

            #endregion

            #region 客户账户

            var users = new List<Customer>
            {
                new Customer
                {
                    Account = "test001",
                    Password = PasswordHelper.DESEncrypt("123123"),
                    DisplayName = "测试用户1",
                    CreateTime = DateTime.Now
                },
                new Customer
                {
                    Account = "test002",
                    Password = PasswordHelper.DESEncrypt("123123"),
                    DisplayName = "测试用户2",
                    CreateTime = DateTime.Now
                }
            };

            users.ForEach(item => context.Customers.Add(item));

            context.SaveChanges();

            #endregion

            #region 产品分类

            #region 一级分类

            var homeAppliance = new BaseCategory()
            {
                PID = null,
                OrderID = 1,
                CateName = "家用电器",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(homeAppliance);

            var mobilePhone = new BaseCategory()
            {
                PID = null,
                OrderID = 2,
                CateName = "手机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(mobilePhone);

            var mobileOperator = new BaseCategory()
            {
                PID = null,
                OrderID = 3,
                CateName = "运营商",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(mobileOperator);

            var digitalProduct = new BaseCategory()
            {
                PID = null,
                OrderID = 4,
                CateName = "数码",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(digitalProduct);

            var computer = new BaseCategory()
            {
                PID = null,
                OrderID = 5,
                CateName = "电脑",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(computer);

            var office = new BaseCategory()
            {
                PID = null,
                OrderID = 6,
                CateName = "办公",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(office);

            var homefurnishing = new BaseCategory()
            {
                PID = null,
                OrderID = 7,
                CateName = "家居",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(homefurnishing);

            var furniture = new BaseCategory()
            {
                PID = null,
                OrderID = 8,
                CateName = "家具",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(furniture);

            var homedecoration = new BaseCategory()
            {
                PID = null,
                OrderID = 9,
                CateName = "家装",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(homedecoration);

            var kitchenware = new BaseCategory()
            {
                PID = null,
                OrderID = 10,
                CateName = "厨具",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(kitchenware);

            var clothing = new BaseCategory()
            {
                PID = null,
                OrderID = 11,
                CateName = "服装",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(clothing);

            var shoes = new BaseCategory()
            {
                PID = null,
                OrderID = 12,
                CateName = "鞋子",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(shoes);

            var underClothes = new BaseCategory()
            {
                PID = null,
                OrderID = 13,
                CateName = "内衣",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(underClothes);

            var beautyMakeup = new BaseCategory()
            {
                PID = null,
                OrderID = 14,
                CateName = "美妆",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(beautyMakeup);

            var personalCleaning = new BaseCategory()
            {
                PID = null,
                OrderID = 15,
                CateName = "个护清洁",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(personalCleaning);

            var pet = new BaseCategory()
            {
                PID = null,
                OrderID = 16,
                CateName = "宠物",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(pet);

            var pluggageet = new BaseCategory()
            {
                PID = null,
                OrderID = 17,
                CateName = "箱包",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(pluggageet);

            var timepiece = new BaseCategory()
            {
                PID = null,
                OrderID = 18,
                CateName = "钟表",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(timepiece);

            var jewelry = new BaseCategory()
            {
                PID = null,
                OrderID = 19,
                CateName = "珠宝",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(jewelry);

            var outdoors = new BaseCategory()
            {
                PID = null,
                OrderID = 20,
                CateName = "户外",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(outdoors);

            var sports = new BaseCategory()
            {
                PID = null,
                OrderID = 21,
                CateName = "运动",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(sports);

            var houseproperty = new BaseCategory()
            {
                PID = null,
                OrderID = 22,
                CateName = "房产",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(houseproperty);

            var automobile = new BaseCategory()
            {
                PID = null,
                OrderID = 23,
                CateName = "汽车",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(automobile);

            var carAppliances = new BaseCategory()
            {
                PID = null,
                OrderID = 24,
                CateName = "汽车用具",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(carAppliances);

            var motherToChild = new BaseCategory()
            {
                PID = null,
                OrderID = 25,
                CateName = "母婴",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(motherToChild);

            var toyMusicalInstrument = new BaseCategory()
            {
                PID = null,
                OrderID = 26,
                CateName = "玩具乐器",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(toyMusicalInstrument);

            var food = new BaseCategory()
            {
                PID = null,
                OrderID = 27,
                CateName = "食品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(food);

            var liquor = new BaseCategory()
            {
                PID = null,
                OrderID = 28,
                CateName = "酒类",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(liquor);

            var fresh = new BaseCategory()
            {
                PID = null,
                OrderID = 29,
                CateName = "生鲜",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(fresh);

            var specialty = new BaseCategory()
            {
                PID = null,
                OrderID = 30,
                CateName = "特产",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(specialty);

            var art = new BaseCategory()
            {
                PID = null,
                OrderID = 31,
                CateName = "艺术",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(art);

            var gift = new BaseCategory()
            {
                PID = null,
                OrderID = 32,
                CateName = "礼品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(gift);

            var flower = new BaseCategory()
            {
                PID = null,
                OrderID = 33,
                CateName = "鲜花",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(flower);

            var agriculture = new BaseCategory()
            {
                PID = null,
                OrderID = 34,
                CateName = "农资",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(agriculture);

            var healthMedica = new BaseCategory()
            {
                PID = null,
                OrderID = 35,
                CateName = "医药保健",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(healthMedica);

            var book = new BaseCategory()
            {
                PID = null,
                OrderID = 36,
                CateName = "图书",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(book);

            var entertainment = new BaseCategory()
            {
                PID = null,
                OrderID = 37,
                CateName = "娱乐",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(entertainment);

            var electronicBook = new BaseCategory()
            {
                PID = null,
                OrderID = 38,
                CateName = "电子书",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(electronicBook);

            var airTicket = new BaseCategory()
            {
                PID = null,
                OrderID = 39,
                CateName = "机票",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(airTicket);

            var hotel = new BaseCategory()
            {
                PID = null,
                OrderID = 40,
                CateName = "酒店",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(hotel);

            var travel = new BaseCategory()
            {
                PID = null,
                OrderID = 41,
                CateName = "旅游",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(travel);

            var dailyUse = new BaseCategory()
            {
                PID = null,
                OrderID = 42,
                CateName = "生活日用",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(dailyUse);

            var installRepaireService = new BaseCategory()
            {
                PID = null,
                OrderID = 43,
                CateName = "安装维修",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(installRepaireService);

            var cleaningMaintenance = new BaseCategory()
            {
                PID = null,
                OrderID = 44,
                CateName = "清洗保养",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(cleaningMaintenance);

            var industrialProducts = new BaseCategory()
            {
                PID = null,
                OrderID = 45,
                CateName = "工业品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(industrialProducts);

            context.SaveChanges();

            #endregion

            #region 二级分类

            #region 家用电器

            var television = new BaseCategory()
            {
                PID = homeAppliance.CateID,  // 一级分类的ID
                OrderID = 1,  // 从1到3
                CateName = "电视",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(television);

            var airConditioner = new BaseCategory()
            {
                PID = homeAppliance.CateID,
                OrderID = 2,
                CateName = "空调",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(airConditioner);

            var washingMachine = new BaseCategory()
            {
                PID = homeAppliance.CateID,
                OrderID = 3,
                CateName = "洗衣机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(washingMachine);

            #endregion

            #region 手机

            var smartPhone = new BaseCategory()
            {
                PID = mobilePhone.CateID,
                OrderID = 1,
                CateName = "智能手机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(smartPhone);

            var gamePhone = new BaseCategory()
            {
                PID = mobilePhone.CateID,
                OrderID = 2,
                CateName = "游戏手机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(gamePhone);

            var elderPhone = new BaseCategory()
            {
                PID = mobilePhone.CateID,
                OrderID = 3,
                CateName = "老人机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(elderPhone);

            #endregion

            #region 电脑

            var laptop = new BaseCategory()
            {
                PID = computer.CateID,
                OrderID = 1,
                CateName = "笔记本",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(laptop);

            var gameLaptop = new BaseCategory()
            {
                PID = computer.CateID,
                OrderID = 2,
                CateName = "游戏本",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(gameLaptop);

            var desktopComputer = new BaseCategory()
            {
                PID = computer.CateID,
                OrderID = 3,
                CateName = "台式机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(desktopComputer);

            #endregion

            #region 数码

            var photography = new BaseCategory()
            {
                PID = digitalProduct.CateID,
                OrderID = 1,
                CateName = "摄像摄影",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(photography);

            var intelligentDevice = new BaseCategory()
            {
                PID = digitalProduct.CateID,
                OrderID = 2,
                CateName = "智能设备",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(intelligentDevice);

            var electronicEducation = new BaseCategory()
            {
                PID = digitalProduct.CateID,
                OrderID = 3,
                CateName = "电子教育",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(electronicEducation);

            #endregion

            #region 办公

            var officeEquipment = new BaseCategory()
            {
                PID = office.CateID,
                OrderID = 1,
                CateName = "办公设备",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(officeEquipment);

            var stationery = new BaseCategory()
            {
                PID = office.CateID,
                OrderID = 2,
                CateName = "文具",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(stationery);

            var consumptiveMaterial = new BaseCategory()
            {
                PID = office.CateID,
                OrderID = 3,
                CateName = "耗材",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(consumptiveMaterial);

            #endregion

            #region 美妆

            var facialskincare = new BaseCategory()
            {
                PID = beautyMakeup.CateID,
                OrderID = 1,
                CateName = "面部护肤",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(facialskincare);

            var perfumeMakeup = new BaseCategory()
            {
                PID = beautyMakeup.CateID,
                OrderID = 2,
                CateName = "香水彩妆",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(perfumeMakeup);

            #endregion

            #region 运动

            var sportswear = new BaseCategory()
            {
                PID = sports.CateID,
                OrderID = 1,
                CateName = "运动服饰",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(sportswear);

            var bodyBuilding = new BaseCategory()
            {
                PID = sports.CateID,
                OrderID = 2,
                CateName = "健身训练",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(bodyBuilding);

            var ridingSport = new BaseCategory()
            {
                PID = sports.CateID,
                OrderID = 3,
                CateName = "骑行运动",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(ridingSport);

            #endregion

            #region 户外

            var outdoorFootwear = new BaseCategory()
            {
                PID = outdoors.CateID,
                OrderID = 1,
                CateName = "户外鞋服",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(outdoorFootwear);

            var outdoorgear = new BaseCategory()
            {
                PID = outdoors.CateID,
                OrderID = 2,
                CateName = "户外装备",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(outdoorgear);

            var fishingrods = new BaseCategory()
            {
                PID = outdoors.CateID,
                OrderID = 3,
                CateName = "垂钓用品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(fishingrods);

            #endregion

            #region 母婴

            var milkpowder = new BaseCategory()
            {
                PID = motherToChild.CateID,
                OrderID = 1,
                CateName = "奶粉",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(milkpowder);

            var wetpants = new BaseCategory()
            {
                PID = motherToChild.CateID,
                OrderID = 2,
                CateName = "尿裤湿巾",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(wetpants);

            var feedingProducts = new BaseCategory()
            {
                PID = motherToChild.CateID,
                OrderID = 3,
                CateName = "喂养用品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(feedingProducts);

            #endregion

            #region 玩具乐器

            var toys = new BaseCategory()
            {
                PID = toyMusicalInstrument.CateID,
                OrderID = 1,
                CateName = "玩具",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(toys);

            var musicalInstruments = new BaseCategory()
            {
                PID = toyMusicalInstrument.CateID,
                OrderID = 2,
                CateName = "乐器",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(musicalInstruments);

            #endregion

            #region 食品

            var fruit = new BaseCategory()
            {
                PID = food.CateID,
                OrderID = 1,
                CateName = "新鲜水果",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(fruit);

            var vegetable_egg = new BaseCategory()
            {
                PID = food.CateID,
                OrderID = 2,
                CateName = "蔬菜蛋品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(vegetable_egg);

            var selectedMeat = new BaseCategory()
            {
                PID = food.CateID,
                OrderID = 3,
                CateName = "精选肉类",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(selectedMeat);

            #endregion

            #region 农资

            var seed = new BaseCategory()
            {
                PID = agriculture.CateID,
                OrderID = 1,
                CateName = "种子",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(seed);

            var pesticides = new BaseCategory()
            {
                PID = agriculture.CateID,
                OrderID = 2,
                CateName = "农药",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(pesticides);

            var fertilizer = new BaseCategory()
            {
                PID = agriculture.CateID,
                OrderID = 3,
                CateName = "肥料",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(fertilizer);

            #endregion

            #region 医药保健

            var pharmaceuticals = new BaseCategory()
            {
                PID = healthMedica.CateID,
                OrderID = 1,
                CateName = "中西药品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(pharmaceuticals);

            var nutritionHealth = new BaseCategory()
            {
                PID = healthMedica.CateID,
                OrderID = 2,
                CateName = "营养健康",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(nutritionHealth);

            var nutritionalComponents = new BaseCategory()
            {
                PID = healthMedica.CateID,
                OrderID = 3,
                CateName = "营养成分",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(nutritionalComponents);

            #endregion

            #region 图书

            var literature = new BaseCategory()
            {
                PID = book.CateID,
                OrderID = 1,
                CateName = "文学",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(literature);

            var childrenBooks = new BaseCategory()
            {
                PID = book.CateID,
                OrderID = 2,
                CateName = "童书",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(childrenBooks);

            var importedTextbook = new BaseCategory()
            {
                PID = book.CateID,
                OrderID = 3,
                CateName = "教材教辅",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(importedTextbook);

            #endregion

            #region 安装

            var applianceInstallation = new BaseCategory()
            {
                PID = installRepaireService.CateID,
                OrderID = 1,
                CateName = "家电安装",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(applianceInstallation);

            var officeInstallation = new BaseCategory()
            {
                PID = installRepaireService.CateID,
                OrderID = 2,
                CateName = "办公安装",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(officeInstallation);

            var furnitureInstallation = new BaseCategory()
            {
                PID = installRepaireService.CateID,
                OrderID = 3,
                CateName = "家具安装",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(furnitureInstallation);

            #endregion

            #region 清洗保养

            var cleaning = new BaseCategory()
            {
                PID = cleaningMaintenance.CateID,
                OrderID = 1,
                CateName = "清洗保养",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(cleaning);

            var characteristicService = new BaseCategory()
            {
                PID = cleaningMaintenance.CateID,
                OrderID = 2,
                CateName = "特色服务",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(characteristicService);

            #endregion

            #region 工业品

            var tool = new BaseCategory()
            {
                PID = industrialProducts.CateID,
                OrderID = 1,
                CateName = "工具",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(tool);

            var cleaningProducts = new BaseCategory()
            {
                PID = industrialProducts.CateID,
                OrderID = 2,
                CateName = "清洁用品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(cleaningProducts);

            var chemical = new BaseCategory()
            {
                PID = industrialProducts.CateID,
                OrderID = 3,
                CateName = "化学品",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(chemical);

            #endregion

            context.SaveChanges();

            #endregion

            #region 三级分类

            #region 电视

            var televisionChild_1 = new BaseCategory()
            {
                PID = television.CateID,
                OrderID = 1,
                CateName = "曲面电视",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(televisionChild_1);

            var televisionChild_2 = new BaseCategory()
            {
                PID = television.CateID,
                OrderID = 1,
                CateName = "超薄电视",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(televisionChild_2);

            var televisionChild_3 = new BaseCategory()
            {
                PID = television.CateID,
                OrderID = 1,
                CateName = "OLED电视",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(televisionChild_3);

            #endregion

            #region 空调

            var airConditionerChild_1 = new BaseCategory()
            {
                PID = airConditioner.CateID,
                OrderID = 2,
                CateName = "壁挂式空调",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(airConditionerChild_1);

            var airConditionerChild_2 = new BaseCategory()
            {
                PID = airConditioner.CateID,
                OrderID = 2,
                CateName = "柜式空调",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(airConditionerChild_2);

            var airConditionerChild_3 = new BaseCategory()
            {
                PID = airConditioner.CateID,
                OrderID = 2,
                CateName = "中央空调",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(airConditionerChild_3);

            #endregion

            #region 洗衣机

            var washingMachineChild_1 = new BaseCategory()
            {
                PID = washingMachine.CateID,
                OrderID = 3,
                CateName = "滚筒洗衣机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(washingMachineChild_1);

            var washingMachineChild_2 = new BaseCategory()
            {
                PID = washingMachine.CateID,
                OrderID = 3,
                CateName = "洗烘一体机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(washingMachineChild_2);

            var washingMachineChild_3 = new BaseCategory()
            {
                PID = washingMachine.CateID,
                OrderID = 3,
                CateName = "迷你洗衣机",
                Status = true,
                CreateTime = DateTime.Now
            };
            context.BaseCategories.Add(washingMachineChild_3);

            #endregion

            context.SaveChanges();

            #endregion

            #endregion

            base.Seed(context);
        }

    }
}
