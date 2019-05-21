using System;
using System.Collections.Generic;
using System.Data.Entity;
using OnlineShopSystem.Model.Category;
using OnlineShopSystem.Model.User;
using OnlineShopSystem.Security;
using OnlineShopSystem.Model.Production;
using System.Configuration;

namespace OnlineShopSystem.Model
{
    /// <summary>
    /// 数据库初始化类
    /// </summary>
    public class SysDbInitializer : DropCreateDatabaseAlways<SysContext>
    {
        protected string site_root_path = ConfigurationManager.AppSettings["SiteRootPath"].ToString();

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
                    CreateTime = DateTime.Now,
                    AdminLevel = 1
                },
                new Administrator
                {
                    Account = "admin002",
                    Password = "123123",
                    DisplayName = "2号管理员",
                    CreateTime = DateTime.Now,
                    AdminLevel = 1
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
                    Account = "user1",
                    Password = PasswordHelper.DESEncrypt("123123"),
                    DisplayName = "Silmeria",
                    CreateTime = DateTime.Now,
                    IsOnline = false
                },
                new Customer
                {
                    Account = "user2",
                    Password = PasswordHelper.DESEncrypt("123123"),
                    DisplayName = "Alicia",
                    CreateTime = DateTime.Now
                }
            };

            users.ForEach(item => context.Customers.Add(item));

            context.SaveChanges();

            #endregion

            #region 商品分类

            #region 一级分类

            var homeAppliance = new ProductCategory()
            {
                PID = null,
                OrderID = 1,
                CateName = "家用电器",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(homeAppliance);

            var mobilePhone = new ProductCategory()
            {
                PID = null,
                OrderID = 2,
                CateName = "手机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(mobilePhone);

            var mobileOperator = new ProductCategory()
            {
                PID = null,
                OrderID = 3,
                CateName = "运营商",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(mobileOperator);

            var digitalProduct = new ProductCategory()
            {
                PID = null,
                OrderID = 4,
                CateName = "数码",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(digitalProduct);

            var computer = new ProductCategory()
            {
                PID = null,
                OrderID = 5,
                CateName = "电脑",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(computer);

            var office = new ProductCategory()
            {
                PID = null,
                OrderID = 6,
                CateName = "办公",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(office);

            var homefurnishing = new ProductCategory()
            {
                PID = null,
                OrderID = 7,
                CateName = "家居",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(homefurnishing);

            var furniture = new ProductCategory()
            {
                PID = null,
                OrderID = 8,
                CateName = "家具",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(furniture);

            var homedecoration = new ProductCategory()
            {
                PID = null,
                OrderID = 9,
                CateName = "家装",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(homedecoration);

            var kitchenware = new ProductCategory()
            {
                PID = null,
                OrderID = 10,
                CateName = "厨具",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(kitchenware);

            var clothing = new ProductCategory()
            {
                PID = null,
                OrderID = 11,
                CateName = "服装",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(clothing);

            var shoes = new ProductCategory()
            {
                PID = null,
                OrderID = 12,
                CateName = "鞋子",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(shoes);

            var underClothes = new ProductCategory()
            {
                PID = null,
                OrderID = 13,
                CateName = "内衣",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(underClothes);

            var beautyMakeup = new ProductCategory()
            {
                PID = null,
                OrderID = 14,
                CateName = "美妆",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(beautyMakeup);

            var personalCleaning = new ProductCategory()
            {
                PID = null,
                OrderID = 15,
                CateName = "个护清洁",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(personalCleaning);

            var pet = new ProductCategory()
            {
                PID = null,
                OrderID = 16,
                CateName = "宠物",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(pet);

            var pluggageet = new ProductCategory()
            {
                PID = null,
                OrderID = 17,
                CateName = "箱包",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(pluggageet);

            var timepiece = new ProductCategory()
            {
                PID = null,
                OrderID = 18,
                CateName = "钟表",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(timepiece);

            var jewelry = new ProductCategory()
            {
                PID = null,
                OrderID = 19,
                CateName = "珠宝",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(jewelry);

            var outdoors = new ProductCategory()
            {
                PID = null,
                OrderID = 20,
                CateName = "户外",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(outdoors);

            var sports = new ProductCategory()
            {
                PID = null,
                OrderID = 21,
                CateName = "运动",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(sports);

            var houseproperty = new ProductCategory()
            {
                PID = null,
                OrderID = 22,
                CateName = "房产",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(houseproperty);

            var automobile = new ProductCategory()
            {
                PID = null,
                OrderID = 23,
                CateName = "汽车",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(automobile);

            var carAppliances = new ProductCategory()
            {
                PID = null,
                OrderID = 24,
                CateName = "汽车用具",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(carAppliances);

            var motherToChild = new ProductCategory()
            {
                PID = null,
                OrderID = 25,
                CateName = "母婴",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(motherToChild);

            var toyMusicalInstrument = new ProductCategory()
            {
                PID = null,
                OrderID = 26,
                CateName = "玩具乐器",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(toyMusicalInstrument);

            var food = new ProductCategory()
            {
                PID = null,
                OrderID = 27,
                CateName = "食品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(food);

            var liquor = new ProductCategory()
            {
                PID = null,
                OrderID = 28,
                CateName = "酒类",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(liquor);

            var fresh = new ProductCategory()
            {
                PID = null,
                OrderID = 29,
                CateName = "生鲜",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(fresh);

            var specialty = new ProductCategory()
            {
                PID = null,
                OrderID = 30,
                CateName = "特产",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(specialty);

            var art = new ProductCategory()
            {
                PID = null,
                OrderID = 31,
                CateName = "艺术",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(art);

            var gift = new ProductCategory()
            {
                PID = null,
                OrderID = 32,
                CateName = "礼品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(gift);

            var flower = new ProductCategory()
            {
                PID = null,
                OrderID = 33,
                CateName = "鲜花",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(flower);

            var agriculture = new ProductCategory()
            {
                PID = null,
                OrderID = 34,
                CateName = "农资",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(agriculture);

            var healthMedica = new ProductCategory()
            {
                PID = null,
                OrderID = 35,
                CateName = "医药保健",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(healthMedica);

            var book = new ProductCategory()
            {
                PID = null,
                OrderID = 36,
                CateName = "图书",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(book);

            var entertainment = new ProductCategory()
            {
                PID = null,
                OrderID = 37,
                CateName = "娱乐",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(entertainment);

            var electronicBook = new ProductCategory()
            {
                PID = null,
                OrderID = 38,
                CateName = "电子书",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(electronicBook);

            var airTicket = new ProductCategory()
            {
                PID = null,
                OrderID = 39,
                CateName = "机票",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(airTicket);

            var hotel = new ProductCategory()
            {
                PID = null,
                OrderID = 40,
                CateName = "酒店",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(hotel);

            var travel = new ProductCategory()
            {
                PID = null,
                OrderID = 41,
                CateName = "旅游",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(travel);

            var dailyUse = new ProductCategory()
            {
                PID = null,
                OrderID = 42,
                CateName = "生活日用",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(dailyUse);

            var installRepaireService = new ProductCategory()
            {
                PID = null,
                OrderID = 43,
                CateName = "安装维修",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(installRepaireService);

            var cleaningMaintenance = new ProductCategory()
            {
                PID = null,
                OrderID = 44,
                CateName = "清洗保养",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(cleaningMaintenance);

            var industrialProducts = new ProductCategory()
            {
                PID = null,
                OrderID = 45,
                CateName = "工业品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(industrialProducts);

            context.SaveChanges();

            #endregion

            #region 二级分类

            #region 家用电器

            var television = new ProductCategory()
            {
                PID = homeAppliance.CateID,  // 一级分类的ID
                OrderID = 1,  // 从1到3
                CateName = "电视",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(television);

            var airConditioner = new ProductCategory()
            {
                PID = homeAppliance.CateID,
                OrderID = 2,
                CateName = "空调",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(airConditioner);

            var washingMachine = new ProductCategory()
            {
                PID = homeAppliance.CateID,
                OrderID = 3,
                CateName = "洗衣机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(washingMachine);

            #endregion

            #region 手机

            var smartPhone = new ProductCategory()
            {
                PID = mobilePhone.CateID,
                OrderID = 1,
                CateName = "智能手机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(smartPhone);

            var gamePhone = new ProductCategory()
            {
                PID = mobilePhone.CateID,
                OrderID = 2,
                CateName = "游戏手机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(gamePhone);

            var elderPhone = new ProductCategory()
            {
                PID = mobilePhone.CateID,
                OrderID = 3,
                CateName = "老人机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(elderPhone);

            #endregion

            #region 电脑

            var laptop = new ProductCategory()
            {
                PID = computer.CateID,
                OrderID = 1,
                CateName = "笔记本",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(laptop);

            var gameLaptop = new ProductCategory()
            {
                PID = computer.CateID,
                OrderID = 2,
                CateName = "游戏本",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(gameLaptop);

            var desktopComputer = new ProductCategory()
            {
                PID = computer.CateID,
                OrderID = 3,
                CateName = "台式机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(desktopComputer);

            #endregion

            #region 数码

            var photography = new ProductCategory()
            {
                PID = digitalProduct.CateID,
                OrderID = 1,
                CateName = "摄像摄影",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(photography);

            var intelligentDevice = new ProductCategory()
            {
                PID = digitalProduct.CateID,
                OrderID = 2,
                CateName = "智能设备",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(intelligentDevice);

            var electronicEducation = new ProductCategory()
            {
                PID = digitalProduct.CateID,
                OrderID = 3,
                CateName = "电子教育",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(electronicEducation);

            #endregion

            #region 办公

            var officeEquipment = new ProductCategory()
            {
                PID = office.CateID,
                OrderID = 1,
                CateName = "办公设备",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(officeEquipment);

            var stationery = new ProductCategory()
            {
                PID = office.CateID,
                OrderID = 2,
                CateName = "文具",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(stationery);

            var consumptiveMaterial = new ProductCategory()
            {
                PID = office.CateID,
                OrderID = 3,
                CateName = "耗材",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(consumptiveMaterial);

            #endregion

            #region 美妆

            var facialskincare = new ProductCategory()
            {
                PID = beautyMakeup.CateID,
                OrderID = 1,
                CateName = "面部护肤",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(facialskincare);

            var perfumeMakeup = new ProductCategory()
            {
                PID = beautyMakeup.CateID,
                OrderID = 2,
                CateName = "香水彩妆",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(perfumeMakeup);

            #endregion

            #region 运动

            var sportswear = new ProductCategory()
            {
                PID = sports.CateID,
                OrderID = 1,
                CateName = "运动服饰",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(sportswear);

            var bodyBuilding = new ProductCategory()
            {
                PID = sports.CateID,
                OrderID = 2,
                CateName = "健身训练",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(bodyBuilding);

            var ridingSport = new ProductCategory()
            {
                PID = sports.CateID,
                OrderID = 3,
                CateName = "骑行运动",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(ridingSport);

            #endregion

            #region 户外

            var outdoorFootwear = new ProductCategory()
            {
                PID = outdoors.CateID,
                OrderID = 1,
                CateName = "户外鞋服",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(outdoorFootwear);

            var outdoorgear = new ProductCategory()
            {
                PID = outdoors.CateID,
                OrderID = 2,
                CateName = "户外装备",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(outdoorgear);

            var fishingrods = new ProductCategory()
            {
                PID = outdoors.CateID,
                OrderID = 3,
                CateName = "垂钓用品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(fishingrods);

            #endregion

            #region 母婴

            var milkpowder = new ProductCategory()
            {
                PID = motherToChild.CateID,
                OrderID = 1,
                CateName = "奶粉",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(milkpowder);

            var wetpants = new ProductCategory()
            {
                PID = motherToChild.CateID,
                OrderID = 2,
                CateName = "尿裤湿巾",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(wetpants);

            var feedingProducts = new ProductCategory()
            {
                PID = motherToChild.CateID,
                OrderID = 3,
                CateName = "喂养用品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(feedingProducts);

            #endregion

            #region 玩具乐器

            var toys = new ProductCategory()
            {
                PID = toyMusicalInstrument.CateID,
                OrderID = 1,
                CateName = "玩具",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(toys);

            var musicalInstruments = new ProductCategory()
            {
                PID = toyMusicalInstrument.CateID,
                OrderID = 2,
                CateName = "乐器",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(musicalInstruments);

            #endregion

            #region 食品

            var fruit = new ProductCategory()
            {
                PID = food.CateID,
                OrderID = 1,
                CateName = "新鲜水果",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(fruit);

            var vegetable_egg = new ProductCategory()
            {
                PID = food.CateID,
                OrderID = 2,
                CateName = "蔬菜蛋品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(vegetable_egg);

            var selectedMeat = new ProductCategory()
            {
                PID = food.CateID,
                OrderID = 3,
                CateName = "精选肉类",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(selectedMeat);

            #endregion

            #region 农资

            var seed = new ProductCategory()
            {
                PID = agriculture.CateID,
                OrderID = 1,
                CateName = "种子",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(seed);

            var pesticides = new ProductCategory()
            {
                PID = agriculture.CateID,
                OrderID = 2,
                CateName = "农药",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(pesticides);

            var fertilizer = new ProductCategory()
            {
                PID = agriculture.CateID,
                OrderID = 3,
                CateName = "肥料",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(fertilizer);

            #endregion

            #region 医药保健

            var pharmaceuticals = new ProductCategory()
            {
                PID = healthMedica.CateID,
                OrderID = 1,
                CateName = "中西药品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(pharmaceuticals);

            var nutritionHealth = new ProductCategory()
            {
                PID = healthMedica.CateID,
                OrderID = 2,
                CateName = "营养健康",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(nutritionHealth);

            var nutritionalComponents = new ProductCategory()
            {
                PID = healthMedica.CateID,
                OrderID = 3,
                CateName = "营养成分",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(nutritionalComponents);

            #endregion

            #region 图书

            var literature = new ProductCategory()
            {
                PID = book.CateID,
                OrderID = 1,
                CateName = "文学",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(literature);

            var childrenBooks = new ProductCategory()
            {
                PID = book.CateID,
                OrderID = 2,
                CateName = "童书",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(childrenBooks);

            var importedTextbook = new ProductCategory()
            {
                PID = book.CateID,
                OrderID = 3,
                CateName = "教材教辅",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(importedTextbook);

            #endregion

            #region 安装

            var applianceInstallation = new ProductCategory()
            {
                PID = installRepaireService.CateID,
                OrderID = 1,
                CateName = "家电安装",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(applianceInstallation);

            var officeInstallation = new ProductCategory()
            {
                PID = installRepaireService.CateID,
                OrderID = 2,
                CateName = "办公安装",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(officeInstallation);

            var furnitureInstallation = new ProductCategory()
            {
                PID = installRepaireService.CateID,
                OrderID = 3,
                CateName = "家具安装",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(furnitureInstallation);

            #endregion

            #region 清洗保养

            var cleaning = new ProductCategory()
            {
                PID = cleaningMaintenance.CateID,
                OrderID = 1,
                CateName = "清洗保养",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(cleaning);

            var characteristicService = new ProductCategory()
            {
                PID = cleaningMaintenance.CateID,
                OrderID = 2,
                CateName = "特色服务",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(characteristicService);

            #endregion

            #region 工业品

            var tool = new ProductCategory()
            {
                PID = industrialProducts.CateID,
                OrderID = 1,
                CateName = "工具",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(tool);

            var cleaningProducts = new ProductCategory()
            {
                PID = industrialProducts.CateID,
                OrderID = 2,
                CateName = "清洁用品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(cleaningProducts);

            var chemical = new ProductCategory()
            {
                PID = industrialProducts.CateID,
                OrderID = 3,
                CateName = "化学品",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(chemical);

            #endregion

            context.SaveChanges();

            #endregion

            #region 三级分类

            #region 电视

            var televisionChild_1 = new ProductCategory()
            {
                PID = television.CateID,
                OrderID = 1,
                CateName = "曲面电视",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(televisionChild_1);

            var televisionChild_2 = new ProductCategory()
            {
                PID = television.CateID,
                OrderID = 1,
                CateName = "超薄电视",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(televisionChild_2);

            var televisionChild_3 = new ProductCategory()
            {
                PID = television.CateID,
                OrderID = 1,
                CateName = "OLED电视",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(televisionChild_3);

            #endregion

            #region 空调

            var airConditionerChild_1 = new ProductCategory()
            {
                PID = airConditioner.CateID,
                OrderID = 2,
                CateName = "壁挂式空调",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(airConditionerChild_1);

            var airConditionerChild_2 = new ProductCategory()
            {
                PID = airConditioner.CateID,
                OrderID = 2,
                CateName = "柜式空调",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(airConditionerChild_2);

            var airConditionerChild_3 = new ProductCategory()
            {
                PID = airConditioner.CateID,
                OrderID = 2,
                CateName = "中央空调",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(airConditionerChild_3);

            #endregion

            #region 洗衣机

            var washingMachineChild_1 = new ProductCategory()
            {
                PID = washingMachine.CateID,
                OrderID = 3,
                CateName = "滚筒洗衣机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(washingMachineChild_1);

            var washingMachineChild_2 = new ProductCategory()
            {
                PID = washingMachine.CateID,
                OrderID = 3,
                CateName = "洗烘一体机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(washingMachineChild_2);

            var washingMachineChild_3 = new ProductCategory()
            {
                PID = washingMachine.CateID,
                OrderID = 3,
                CateName = "迷你洗衣机",
                IsUsed = true,
                CreateTime = DateTime.Now
            };
            context.ProductCategories.Add(washingMachineChild_3);

            #endregion

            context.SaveChanges();

            #endregion

            #endregion

            #region 商品

            Product tv_1 = new Product();
            tv_1.Name = "小米（MI）小米电视4X 55英寸 L55M5-AD 2GB+8GB HDR 4K超高清 蓝牙语音遥控 人工智能语音网络液晶平板电视";
            tv_1.SubName = "";
            tv_1.Describe = "";
            tv_1.ThumbImgUrl = site_root_path + "/Images/Products/tv_1.jpg";
            tv_1.MainImgUrl = site_root_path + "/Images/Products/tv_1_main.jpg";
            tv_1.Price = 1999.00;
            tv_1.Stock = 100;
            tv_1.IsUsed = true;
            tv_1.CreateTime = DateTime.Now;
            tv_1.UpdateTime = DateTime.Now;
            context.Products.Add(tv_1);

            Product phone_huawei_1 = new Product();
            phone_huawei_1.Name = "荣耀10青春版 幻彩渐变 2400万AI自拍 全网通版4GB+64GB 渐变蓝 移动联通电信4G全面屏手机 双卡双待";
            phone_huawei_1.SubName = "";
            phone_huawei_1.Describe = "";
            phone_huawei_1.ThumbImgUrl = site_root_path + "/Images/Products/huawei_1.jpg";
            phone_huawei_1.MainImgUrl = site_root_path + "/Images/Products/huawei_1_main.jpg";
            phone_huawei_1.Price = 1299.00;
            phone_huawei_1.Stock = 1000;
            phone_huawei_1.IsUsed = true;
            phone_huawei_1.CreateTime = DateTime.Now;
            phone_huawei_1.UpdateTime = DateTime.Now;
            context.Products.Add(phone_huawei_1);

            Product phone_huawei_2 = new Product();
            phone_huawei_2.Name = "荣耀V20 胡歌同款 麒麟980芯片 魅眼全视屏 4800万深感相机 6GB+128GB 魅海蓝 移动联通电信4G全面屏手机";
            phone_huawei_2.SubName = "";
            phone_huawei_2.Describe = "";
            phone_huawei_2.ThumbImgUrl = site_root_path + "/Images/Products/huawei_2.jpg";
            phone_huawei_2.MainImgUrl = site_root_path + "/Images/Products/huawei_2_main.jpg";
            phone_huawei_2.Price = 2799.00;
            phone_huawei_2.Stock = 1000;
            phone_huawei_2.IsUsed = true;
            phone_huawei_2.CreateTime = DateTime.Now;
            phone_huawei_2.UpdateTime = DateTime.Now;
            context.Products.Add(phone_huawei_2);

            context.SaveChanges();

            #endregion

            #region 商品属性

            ProductAttr tv_1_attr_1 = new ProductAttr();
            tv_1_attr_1.ProductID = tv_1.ProductID;
            tv_1_attr_1.Name = "尺寸";
            context.ProductAttrs.Add(tv_1_attr_1);

            ProductAttr tv_1_attr_2 = new ProductAttr();
            tv_1_attr_2.ProductID = tv_1.ProductID;
            tv_1_attr_2.Name = "版本";
            context.ProductAttrs.Add(tv_1_attr_2);

            ProductAttr phone_huawei_1_attr_1 = new ProductAttr();
            phone_huawei_1_attr_1.ProductID = phone_huawei_1.ProductID;
            phone_huawei_1_attr_1.Name = "颜色";
            context.ProductAttrs.Add(phone_huawei_1_attr_1);

            context.SaveChanges();

            #endregion

            #region 商品属性值

            ProductAttrValue tv_1_attr_1_value_1 = new ProductAttrValue();
            tv_1_attr_1_value_1.ProductID = tv_1.ProductID;
            tv_1_attr_1_value_1.ProductAttrID = tv_1_attr_1.ID;
            tv_1_attr_1_value_1.Value = "小米电视4X 55英寸";
            tv_1_attr_1_value_1.ExtraPrice = 0.00;
            context.ProductAttrValues.Add(tv_1_attr_1_value_1);

            ProductAttrValue tv_1_attr_1_value_2 = new ProductAttrValue();
            tv_1_attr_1_value_2.ProductID = tv_1.ProductID;
            tv_1_attr_1_value_2.ProductAttrID = tv_1_attr_1.ID;
            tv_1_attr_1_value_2.Value = "小米电视4S 55英寸";
            tv_1_attr_1_value_2.ExtraPrice = 800.00;
            context.ProductAttrValues.Add(tv_1_attr_1_value_1);

            ProductAttrValue tv_1_attr_1_value_3 = new ProductAttrValue();
            tv_1_attr_1_value_3.ProductID = tv_1.ProductID;
            tv_1_attr_1_value_3.ProductAttrID = tv_1_attr_1.ID;
            tv_1_attr_1_value_3.Value = "小米电视4S 55英寸 曲面";
            tv_1_attr_1_value_3.ExtraPrice = 1000.00;
            context.ProductAttrValues.Add(tv_1_attr_1_value_1);

            ProductAttrValue tv_1_attr_2_value_1 = new ProductAttrValue();
            tv_1_attr_2_value_1.ProductID = tv_1.ProductID;
            tv_1_attr_2_value_1.ProductAttrID = tv_1_attr_2.ID;
            tv_1_attr_2_value_1.Value = "普通版";
            tv_1_attr_2_value_1.ExtraPrice = 0.00;
            context.ProductAttrValues.Add(tv_1_attr_2_value_1);

            ProductAttrValue tv_1_attr_2_value_2 = new ProductAttrValue();
            tv_1_attr_2_value_2.ProductID = tv_1.ProductID;
            tv_1_attr_2_value_2.ProductAttrID = tv_1_attr_2.ID;
            tv_1_attr_2_value_2.Value = "爱奇艺钻石会员版";
            tv_1_attr_2_value_2.ExtraPrice = 50.00;
            context.ProductAttrValues.Add(tv_1_attr_2_value_2);

            ProductAttrValue phone_huawei_1_attr_1_value_1 = new ProductAttrValue();
            phone_huawei_1_attr_1_value_1.ProductID = phone_huawei_1.ProductID;
            phone_huawei_1_attr_1_value_1.ProductAttrID = phone_huawei_1_attr_1.ID;
            phone_huawei_1_attr_1_value_1.Value = "幻夜黑";
            phone_huawei_1_attr_1_value_1.ExtraPrice = 50.00;
            context.ProductAttrValues.Add(phone_huawei_1_attr_1_value_1);

            ProductAttrValue phone_huawei_1_attr_1_value_2 = new ProductAttrValue();
            phone_huawei_1_attr_1_value_2.ProductID = phone_huawei_1.ProductID;
            phone_huawei_1_attr_1_value_2.ProductAttrID = phone_huawei_1_attr_1.ID;
            phone_huawei_1_attr_1_value_2.Value = "渐变蓝";
            phone_huawei_1_attr_1_value_2.ExtraPrice = 50.00;
            context.ProductAttrValues.Add(phone_huawei_1_attr_1_value_2);

            ProductAttrValue phone_huawei_1_attr_1_value_3 = new ProductAttrValue();
            phone_huawei_1_attr_1_value_3.ProductID = phone_huawei_1.ProductID;
            phone_huawei_1_attr_1_value_3.ProductAttrID = phone_huawei_1_attr_1.ID;
            phone_huawei_1_attr_1_value_3.Value = "渐变红";
            phone_huawei_1_attr_1_value_3.ExtraPrice = 50.00;
            context.ProductAttrValues.Add(phone_huawei_1_attr_1_value_3);

            ProductAttrValue phone_huawei_1_attr_1_value_4 = new ProductAttrValue();
            phone_huawei_1_attr_1_value_4.ProductID = phone_huawei_1.ProductID;
            phone_huawei_1_attr_1_value_4.ProductAttrID = phone_huawei_1_attr_1.ID;
            phone_huawei_1_attr_1_value_4.Value = "铃兰白";
            phone_huawei_1_attr_1_value_4.ExtraPrice = 50.00;
            context.ProductAttrValues.Add(phone_huawei_1_attr_1_value_4);

            context.SaveChanges();

            #endregion

            #region 商品&商品分类关系

            ProductCateRelation tv_1_relation_1 = new ProductCateRelation();
            tv_1_relation_1.ProductID = tv_1.ProductID;
            tv_1_relation_1.CategoryID = television.CateID;
            context.ProductCateRelations.Add(tv_1_relation_1);

            context.SaveChanges();

            #endregion

            base.Seed(context);
        }

    }
}
