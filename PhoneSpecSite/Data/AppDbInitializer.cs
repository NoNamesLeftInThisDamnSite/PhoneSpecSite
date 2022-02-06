using Microsoft.AspNetCore.Identity;
using PhoneSpecSite.Data.Static;
using PhoneSpecSite.Models;

namespace PhoneSpecSite.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

               
                //PhoneCategory
                if (!context.PhoneCompany.Any())
                {
                    context.PhoneCompany.AddRange(new List<PhoneCompany>()
                    {
                        new PhoneCompany ()
                        {
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Samsung_Logo.svg/2560px-Samsung_Logo.svg.png",
                            CompanyName = "Samsung",
                            CompanyDescription = "Samsung specializes in the production of a wide variety of consumer and industry electronics, including appliances, digital media devices, semiconductors, memory chips, and integrated systems. It has become one of the most-recognizable names in technology and produces about a fifth of South Korea's total exports"
                        },
                         new PhoneCompany ()
                        {
                            Logo = "https://worldaiweek.ai/wp-content/uploads/sites/7/2019/02/apple-logo-transparent.png",
                            CompanyName = "Apple",
                            CompanyDescription = "Apple Inc. designs, manufactures and markets smartphones, personal computers, tablets, wearables and accessories, and sells a variety of related services. The Company's products include iPhone, Mac, iPad, and Wearables, Home and Accessories. iPhone is the Company's line of smartphones based on its iOS operating system"
                        },
                          new PhoneCompany ()
                        {
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Xiaomi_logo_%282021-%29.svg/2048px-Xiaomi_logo_%282021-%29.svg.png",
                            CompanyName = "Xiaomi",
                            CompanyDescription = "Xiaomi is a consumer electronics and smart manufacturing company with smartphones and smart hardware connected by an IoT platform at its core. in the world enjoy a better life through innovative technology. Xiaomi is one of the world's leading smartphone companies"
                        },
                           new PhoneCompany ()
                        {
                            Logo = "https://1000logos.net/wp-content/uploads/2017/04/Motorola-Logo.png",
                            CompanyName = "Motorola",
                            CompanyDescription = "Motorola develops analog and digital two-way radio, voice and data communications products and systems, mobile computing, advanced data capture, wireless infrastructure and RFID solutions to customers worldwide"
                        },
                    });
                    context.SaveChanges();
                }
                //Phones
                if (!context.Phones.Any())
                {
                    context.Phones.AddRange(new List<Phones>()
                    {
                           new Phones()
                           {
                               PhoneName = "Samsung Galaxy S21 Ultra",
                               PhoneDescription ="It's a solid and premium-feeling phone with a unique superzoom camera",
                               ReleaseDate ="29.01.2021",
                               PhoneCategory = PhoneCategory.Flagship,
                               Body ="227g, Gorila Glass victus ",
                               Display ="6.8 inches,120HZ,(515 ppi density)",
                               PhoneOS = PhoneOS.Android,
                               Chipset ="Exynos 2100",
                               CPU ="Octa-core",
                               GPU ="Mali-G78",
                               Memory ="128GB 12GB RAM, 256GB 12GB RAM, 512GB 12GB RAM",
                               Camera ="108 MP (wide),10MP(periscope telephoto),10MP(telephoto),12MP(ultrawide)",
                               SelfieCamera ="40MP",
                               Battery ="5000 mAh",
                               Price ="2150 leva",
                               PhonePictureURL ="https://fdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s21-ultra-5g-1.jpg",
                               Id=1
                           },
                          new Phones()
                           {
                               PhoneName = "Xiaomi Mix 4",
                               PhoneDescription ="The first phone to use an under display camera also has ceramic back ",
                               ReleaseDate ="10.08.2021",
                               PhoneCategory = PhoneCategory.Flagship,
                               Body ="225g, Gorila Glass victus ",
                               Display ="6.67 inches,120HZ,(395 ppi density)",
                               PhoneOS = PhoneOS.Android,
                               Chipset ="Snapdragon 888+",
                               CPU ="Octa-core",
                               GPU ="Adreno 660",
                               Memory ="128GB 12GB RAM, 256GB 12GB RAM, 512GB 12GB RAM",
                               Camera ="108 MP (wide),8MP(periscope telephoto),13MP(ultrawide)",
                               SelfieCamera ="20MP",
                               Battery ="4500 mAh",
                               Price ="1598 leva ",
                               PhonePictureURL ="https://fdn2.gsmarena.com/vv/pics/xiaomi/mix-4-1.jpg",
                               Id=3
                           },
                          new Phones()
                           {
                               PhoneName = "Iphone 13 Pro Max",
                               PhoneDescription ="The iPhone 13 Pro Max display has rounded corners that follow a beautiful curved design",
                               ReleaseDate ="14.09.2021",
                               PhoneCategory = PhoneCategory.Flagship,
                               Body ="240g, Gorila Glass 5 ",
                               Display ="6.7 inches,120HZ,(458 ppi density)",
                               PhoneOS = PhoneOS.iOS,
                               Chipset ="Apple A15 Bionic",
                               CPU ="Hexa-core",
                               GPU ="Apple GPU",
                               Memory ="128GB 6GB RAM, 256GB 6GB RAM, 512GB 6GB RAM",
                               Camera ="12 MP (wide),12MP(telephoto),12MP(ultrawide)",
                               SelfieCamera ="12MP",
                               Battery ="4352 mAh",
                               Price ="2489 leva ",
                               PhonePictureURL ="https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-pro-max-01.jpg",
                               Id =2
                           },
                          new Phones()
                           {
                               PhoneName = "Xiaomi Poco x3 Pro",
                               PhoneDescription ="POCO X3 Pro has a new and improved look with a reflective chroma strip Flagship level performance",
                               ReleaseDate ="03.04.2021",
                               PhoneCategory = PhoneCategory.FlagshipKillers,
                               Body ="215g, Gorila Glass 6 ",
                               Display ="6.67 inches,90HZ,(395 ppi density)",
                               PhoneOS = PhoneOS.Android,
                               Chipset ="SnapDragon 860",
                               CPU ="Octa-core",
                               GPU ="Adreno 640",
                               Memory ="128GB 6GB RAM,256GB 6GB RAM,256GB 8GB RAM",
                               Camera ="48MP (wide),8MP(ultrawide),2MP(Macro),2(Depth)",
                               SelfieCamera ="20MP",
                               Battery ="5160 mAh",
                               Price ="510 leva",
                               PhonePictureURL ="https://fdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-poco-x3-pro-1.jpg",
                               Id=3
                           },
                          new Phones()
                           {
                               PhoneName = "Apple IPhone Se",
                               PhoneDescription ="It's a solid and premium-feeling phone with a unique superzoom camera, a gorgeous screen, and future-forward network chops",
                               ReleaseDate ="22.06.2020",
                               PhoneCategory = PhoneCategory.MidRange,
                               Body ="148, Gorila Glass 5 ",
                               Display ="4.7 inches,60HZ,(326 ppi density)",
                               PhoneOS = PhoneOS.iOS,
                               Chipset ="Apple A13 Bionic",
                               CPU ="Hexa-core",
                               GPU ="Apple GPU 4core",
                               Memory ="64GB 3GB RAM, 128GB 3GB RAM, 256GB 3GB RAM",
                               Camera ="12 MP (wide)",
                               SelfieCamera ="7MP",
                               Battery ="1821 mAh",
                               Price ="634 leva ",
                               PhonePictureURL ="https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-se-2020-2.jpg",
                               Id=2
                           },
                          new Phones()
                           {
                               PhoneName = "Motorola Moto X4",
                               PhoneDescription ="It's a solid and premium-feeling phone with a unique superzoom camera, a gorgeous screen, and future-forward network chops",
                               ReleaseDate ="11.12.2017",
                               PhoneCategory = PhoneCategory.LowEnd,
                               Body ="163g, Gorila Glass 3 ",
                               Display ="5.2 inches,30HZ,(515 ppi density)",
                               PhoneOS = PhoneOS.LineageOS,
                               Chipset ="Snapdragon 630",
                               CPU ="Quad-core",
                               GPU ="Adreno 508",
                               Memory ="32GB 3GB RAM, 64GB 4GB RAM, 64GB 6GB RAM",
                               Camera ="12 MP (wide),8MP(ultrawide)",
                               SelfieCamera ="16MP",
                               Battery ="300 mAh",
                               Price ="235 leva",
                               PhonePictureURL ="https://fdn2.gsmarena.com/vv/pics/motorola/motorola-moto-x4-2.jpg",
                               Id=4
                           },


                    }) ;
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                // Roles Creation
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@phonespecs.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Phones@123?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                   }

                
            
               
                string appUserEmail = "user@phonespecs.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "App User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Phones@123?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

            }
        }
    }
}
