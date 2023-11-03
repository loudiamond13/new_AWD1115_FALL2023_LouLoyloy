using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using BikeShop_HOT.Models;

namespace BikeShop_HOT.Models
{
    public class BikeShopContext : DbContext
    {
       //constructor
       public BikeShopContext(DbContextOptions<BikeShopContext> options) : base(options) { }

        // DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category
                 {
                     CategoryID = 1,
                     CategoryName = "Accessories"
                 },
                 new Category
                 {
                     CategoryID = 2,
                     CategoryName = "Bikes"
                 },
                 new Category
                 {
                     CategoryID = 3,
                     CategoryName = "Clothing"
                 },
                 new Category
                 {
                     CategoryID = 4,
                     CategoryName = "Components"
                 },
                 new Category
                 {
                     CategoryID = 5,
                     CategoryName = "Car racks"
                 },
                 new Category
                 {
                     CategoryID = 6,
                     CategoryName = "Wheels"
                 }
             );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    FirstName = "Suzanne",
                    LastName = "Viescas",
                    Address = "15127 NE 24th, #383",
                    City = "Redmond",
                    State = "WA",
                    ZipCode = "98052",
                    PhoneNumber = "425-555-2686"
                },
                new Customer
                {
                    CustomerID = 2,
                    FirstName = "William",
                    LastName = "Thompson",
                    Address = "122 Spring River Drive",
                    City = "Duvall",
                    State = "WA",
                    ZipCode = "98019",
                    PhoneNumber = "425-555-2681"
                },
                new Customer
                {
                    CustomerID = 3,
                    FirstName = "Gary",
                    LastName = "Hallmark",
                    Address = "Route 2, Box 203B",
                    City = "Auburn",
                    State = "WA",
                    ZipCode = "98013",
                    PhoneNumber = "253-555-2676"
                },
                new Customer
                {
                    CustomerID = 4,
                    FirstName = "Robert",
                    LastName = "Brown",
                    Address = "672 Lamont Ave",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77201",
                    PhoneNumber = "713-555-2491"
                },
                new Customer
                {
                    CustomerID = 5,
                    FirstName = "Dean",
                    LastName = "McCrae",
                    Address = "4110 Old Redmond Rd.",
                    City = "Redmond",
                    State = "WA",
                    ZipCode = "98052",
                    PhoneNumber = "425-555-2506"
                },
                new Customer
                {
                    CustomerID = 6,
                    FirstName = "John",
                    LastName = "Viescas",
                    Address = "15127 NE 24th, #383",
                    City = "Redmond",
                    State = "WA",
                    ZipCode = "98052",
                    PhoneNumber = "425-555-2511"
                },
                new Customer
                {
                    CustomerID = 7,
                    FirstName = "Mariya",
                    LastName = "Sergienko",
                    Address = "901 Pine Avenue",
                    City = "Portland",
                    State = "OR",
                    ZipCode = "97208",
                    PhoneNumber = "503-555-2526"
                },
                new Customer
                {
                    CustomerID = 8,
                    FirstName = "Neil",
                    LastName = "Patterson",
                    Address = "233 West Valley Hwy",
                    City = "San Diego",
                    State = "CA",
                    ZipCode = "92199",
                    PhoneNumber = "619-555-2541"
                },
                new Customer
                {
                    CustomerID = 9,
                    FirstName = "Andrew",
                    LastName = "Cencini",
                    Address = "507 - 20th Ave. E. Apt. 2A",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98105",
                    PhoneNumber = "206-555-2601"
                },
                new Customer
                {
                    CustomerID = 10,
                    FirstName = "Angel",
                    LastName = "Kennedy",
                    Address = "667 Red River Road",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78710",
                    PhoneNumber = "512-555-2571"
                },
                new Customer
                {
                    CustomerID = 11,
                    FirstName = "Alaina",
                    LastName = "Hallmark",
                    Address = "Route 2, Box 203B",
                    City = "Woodinville",
                    State = "WA",
                    ZipCode = "98072",
                    PhoneNumber = "425-555-2631",
                },
                new Customer
                {
                    CustomerID = 12,
                    FirstName = "Liz",
                    LastName = "Keyser",
                    Address = "13920 S.E. 40th Street",
                    City = "Bellevue",
                    State = "WA",
                    ZipCode = "98006",
                    PhoneNumber = "425-555-2556"
                },
                new Customer
                {
                    CustomerID = 13,
                    FirstName = "Rachel",
                    LastName = "Patterson",
                    Address = "2114 Longview Lane",
                    City = "San Diego",
                    State = "CA",
                    ZipCode = "92199",
                    PhoneNumber = "619-555-2546"
                },
                new Customer
                {
                    CustomerID = 14,
                    FirstName = "Sam",
                    LastName = "Abolrous",
                    Address = "611 Alpine Drive",
                    City = "Palm Springs",
                    State = "CA",
                    ZipCode = "92263",
                    PhoneNumber = "760-555-2611"
                },
                new Customer
                {
                    CustomerID = 15,
                    FirstName = "Darren",
                    LastName = "Gehring",
                    Address = "2601 Seaview Lane",
                    City = "Chico",
                    State = "CA",
                    ZipCode = "95926",
                    PhoneNumber = "530-555-2616"
                },
                new Customer
                {
                    CustomerID = 16,
                    FirstName = "Jim",
                    LastName = "Wilson",
                    Address = "101 NE 88th",
                    City = "Salem",
                    State = "OR",
                    ZipCode = "97301",
                    PhoneNumber = "503-555-2636"
                },
                new Customer
                {
                    CustomerID = 17,
                    FirstName = "Manuela",
                    LastName = "Seidel",
                    Address = "66 Spring Valley Drive",
                    City = "Medford",
                    State = "OR",
                    ZipCode = "97501",
                    PhoneNumber = "541-555-2641"
                },
                new Customer
                {
                    CustomerID = 18,
                    FirstName = "David",
                    LastName = "Smith",
                    Address = "311 20th Ave. N.E.",
                    City = "Fremont",
                    State = "CA",
                    ZipCode = "94538",
                    PhoneNumber = "510-555-2646"
                },
                new Customer
                {
                    CustomerID = 19,
                    FirstName = "Zachary",
                    LastName = "Ehrlich",
                    Address = "12330 Kingman Drive",
                    City = "Glendale",
                    State = "CA",
                    ZipCode = "91209",
                    PhoneNumber = "819-555-2721"
                },
                new Customer
                {
                    CustomerID = 20,
                    FirstName = "Joyce",
                    LastName = "Bonnicksen",
                    Address = "2424 Thames Drive",
                    City = "Bellevue",
                    State = "WA",
                    ZipCode = "98006",
                    PhoneNumber = "425-555-2726"
                },
                new Customer
                {
                    CustomerID = 21,
                    FirstName = "Estella",
                    LastName = "Pundt",
                    Address = "2500 Rosales Lane",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75260",
                    PhoneNumber = "972-555-9938"
                },
                new Customer
                {
                    CustomerID = 22,
                    FirstName = "Caleb",
                    LastName = "Viescas",
                    Address = "4501 Wetland Road",
                    City = "Long Beach",
                    State = "CA",
                    ZipCode = "90809",
                    PhoneNumber = "562-555-0037"
                },
                new Customer
                {
                    CustomerID = 23,
                    FirstName = "Julia",
                    LastName = "Schnebly",
                    Address = "2343 Harmony Lane",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "99837",
                    PhoneNumber = "206-555-9936"
                },
                new Customer
                {
                    CustomerID = 24,
                    FirstName = "Mark",
                    LastName = "Rosales",
                    Address = "323 Advocate Lane",
                    City = "El Paso",
                    State = "TX",
                    ZipCode = "79915",
                    PhoneNumber = "915-555-2286"
                },
                new Customer
                {
                    CustomerID = 25,
                    FirstName = "Maria",
                    LastName = "Patterson",
                    Address = "3445 Cheyenne Road",
                    City = "El Paso",
                    State = "TX",
                    ZipCode = "79915",
                    PhoneNumber = "915-555-2291"
                },
                new Customer
                {
                    CustomerID = 26,
                    FirstName = "Kirk",
                    LastName = "DeGrasse",
                    Address = "455 West Palm Ave",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78284",
                    PhoneNumber = "210-555-2311"
                },
                new Customer
                {
                    CustomerID = 27,
                    FirstName = "Luke",
                    LastName = "Patterson",
                    Address = "877 145th Ave SE",
                    City = "Portland",
                    State = "OR",
                    ZipCode = "97208",
                    PhoneNumber = "503-555-2316"
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Ann",
                    LastName = "Patterson",
                    Address = "16 Maple Lane",
                    City = "Auburn",
                    State = "WA",
                    ZipCode = "98002",
                    PhoneNumber = "253-555-2591"
                },
                new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Mary",
                    LastName = "Thompson",
                    Address = "122 Spring River Drive",
                    City = "Duvall",
                    State = "WA",
                    ZipCode = "98019",
                    PhoneNumber = "425-555-2516"
                },
                new Employee
                {
                    EmployeeID = 3,
                    FirstName = "Matt",
                    LastName = "Berg",
                    Address = "908 W. Capital Way",
                    City = "Tacoma",
                    State = "WA",
                    ZipCode = "98413",
                    PhoneNumber = "253-555-2581"
                },
                new Employee
                {
                    EmployeeID = 4,
                    FirstName = "Carol",
                    LastName = "Viescas",
                    Address = "722 Moss Bay Blvd.",
                    City = "Kirkland",
                    State = "WA",
                    ZipCode = "98033",
                    PhoneNumber = "425-555-2576"
                },
                new Employee
                {
                    EmployeeID = 5,
                    FirstName = "David",
                    LastName = "Viescas",
                    Address = "16679 NE 42nd Court",
                    City = "Redmond",
                    State = "WA",
                    ZipCode = "98052",
                    PhoneNumber = "425-555-2661"
                },
                new Employee
                {
                    EmployeeID = 6,
                    FirstName = "Kirk",
                    LastName = "DeGrasse",
                    Address = "455 West Palm Ave",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78284",
                    PhoneNumber = "210-555-2311"
                },
                new Employee
                {
                    EmployeeID = 7,
                    FirstName = "Kathryn",
                    LastName = "Patterson",
                    Address = "554 E. Wilshire Apt. 2A",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98105",
                    PhoneNumber = "206-555-2697"
                },
                new Employee
                {
                    EmployeeID = 8,
                    FirstName = "Susan",
                    LastName = "McLain",
                    Address = "511 Lenora Ave",
                    City = "Bellevue",
                    State = "WA",
                    ZipCode = "98006",
                    PhoneNumber = "425-555-2301"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    Name = "AeroFlo ATB Wheels",
                    Description = "Greens Lick is a machine built trail designed by Trail Dynamics as a demonstration trail showing the forest service how eroded road beds could be converted to sustainable trail.",
                    Image = "~/content/images/AeroFlo_ATB_Wheels.jpg",
                    Price = (decimal)189,
                    Qty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Clear Shade 85-T Glasses",
                    Description = "This trail can be sandy during dry summer months and is best after rain, in the spring or fall. Rocks for texture, obstacles for fun and some short fast downhils in this 2.",
                    Image = "~/content/images/Clear_Shade_85_T_Glasses.jpg",
                    Price = (decimal)45,
                    Qty = 14,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Cosmic Elite Road Warrior Wheels",
                    Description = "If you keep your momentum you can charge up pretty much all the climbs and the descents are steep and tricky. Very loose and dry. Narrow in places and twisty througout.",
                    Image = "~/content/images/Cosmic_Elite_Road_Warrior_Wheels.jpg",
                    Price = (decimal)165,
                    Qty = 22,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Cycle-Doc Pro Repair Stand",
                    Description = "It has a number of blind LH corners so whistle or use a bell so you can alert anyone coming the opposite way. One of the best rides in all of tahoe.",
                    Image = "~/content/images/Cycle_Doc_Pro_Repair_Stand.jpg",
                    Price = (decimal)166,
                    Qty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Dog Ear Aero-Flow Floor Pump",
                    Description = "From there the trail stretches out and travels pretty fast into a big berm with a view out into the valley. Use caution in the corners. Built specifically for mountain bikes.",
                    Image = "~/content/images/Dog_Ear_Aero_Flow_Floor_Pump.jpg",
                    Price = (decimal)55,
                    Qty = 25,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    Name = "Dog Ear Cycle Computer",
                    Description = "features that are designed in a way that uses the rider’s momentum to minimize pedaling and braking (think downhill pump track). Lots of opportunities for big air.",
                    Image = "~/content/images/Dog_Ear_Cycle_Computer.jpg",

                    Price = (decimal)75,
                    Qty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    Name = "Dog Ear Helmet Mount Mirrors",
                    Description = "Winding trail with dips, climbs and descents. Wait a few days after any fresh snowfall and the entire area becomes one giant freeride trail after the shredders pack down the powder.",
                    Image = "~/content/images/Dog_Ear_Helmet_Mount_Mirror.jpg",
                    Price = (decimal)7.45,
                    Qty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Dog Ear Monster Grip Gloves",
                    Description = "A flow trail emphasizes speed and rhythm, featuring berms, rollers, jumps and other features that are designed in a way that uses the rider’s momentum to minimize pedaling and braking.",
                    Image = "~/content/images/Dog_Ear_Monster_Grip_Gloves.jpg",
                    Price = (decimal)15,
                    Qty = 30,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    Name = "Eagle FS-3 Mountain Bike",
                    Description = "16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008, the State of Alaska installed a more user friendly course in 2012.",
                    Image = "~/content/images/Eagle_FS_3_Mountain_Bike.jpg",
                    Price = (decimal)1800,
                    Qty = 8,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    Name = "Eagle SA-120 Clipless Pedals",
                    Description = "Formerly smooth as glass, it has taken on a very natural character with lots of rollers to soak up or jump. One of the best rides in all of tahoe.",
                    Image = "~/content/images/Eagle_SA_120_Clipless_Pedals.jpg",
                    Price = (decimal)139.50,
                    Qty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    Name = "Glide-O-Matic Cycling Helmet",
                    Description = "It is steep. Check your speed before rumbling over the wet armored section that make a tight right hand turn into a bridge. With moderate climbing involved.",
                    Image = "~/content/images/Glide_O_Matic_Cycling_Helmet.jpg",

                    Price = (decimal)125,
                    Qty = 24,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 12,
                    Name = "GT RTS-2 Mountain Bike",
                    Description = "These trails can keep almost anyone interested for hours. The route begins at the end of Quid Pro Flow and an intersection with Three Thirty Eight.",
                    Image = "~/content/images/GT_RTS_2_Mountain_Bike.jpg",
                    Price = (decimal)1650,
                    Qty = 5,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    Name = "HP Deluxe Panniers",
                    Description = "MBoSC has partnered with land manager California Department of Forestry and Fire Protection (CAL FIRE) to build a four mile flow trail in Soquel Demonstration State Forest (SDSF).",
                    Image = "~/content/images/HP_Deluxe_Panniers.jpg",
                    Price = (decimal)39,
                    Qty = 10,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 14,
                    Name = "King Cobra Helmet",
                    Description = "The area can be accessed from the end of Densmore's Lane, the end of Old Petty Harbour Road and from Huntingdale Drive. One of the best downhills in the area. Pretty dry and fast.",
                    Image = "~/content/images/King_Cobra_Helmet.jpg",
                    Price = (decimal)139,
                    Qty = 30,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 15,
                    Name = "Kool Breeze Rocket Top Jersey",
                    Description = "There is an optional drop 1/2 way down. On the bike map it is often combined as the Whole Enchilada with Porcupine Rim, Kokopelli, Hazard County and Burro Pass.",
                    Image = "~/content/images/Kool_Breeze_Rocket_Top_Jersey.jpg",
                    Price = (decimal)4.99,
                    Qty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    Name = "Kryptonite Advanced 2000 U-Lock",
                    Description = "Great conditions today. Large group of trees down on northern section of trail, between buckhorn and club gap. Long pedal up form town but best when shuttled to the top.",
                    Image = "~/content/images/Kryptonite_Advanced_2000_U_Lock.jpg",
                    Price = (decimal)50,
                    Qty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 17,
                    Name = "Nikoma Lok-Tight U-Lock",
                    Description = "Parking at the bottom is near mile 12 of Palmer Fishhook Road, while the top of the trailhead starts near mile 16 of Palmer Fishhook Road. You can find everyone out here having fun from people.",
                    Image = "~/content/images/Nikoma_Lok_Tight_U_Lock.jpg",
                    Price = (decimal)33,
                    Qty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 18,
                    Name = "ProFormance ATB All-Terrain Pedal",
                    Description = "If you continue, the trail ends at one of the lakes and continues lakeside until reaching the point where you began the trail The lake-side bit is fairly technical and very fun.",
                    Image = "~/content/images/ProFormance_ATB_All_Terrain_Pedal.jpg",
                    Price = (decimal)28,
                    Qty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 19,
                    Name = "ProFormance Toe Klips 2G",
                    Description = "Narrow in places and twisty througout, this leg churner is sure to keep you on you toes. The area can be accessed from the end of Densmore's Lane, the end of Old Petty Harbour Road.",
                    Image = "~/content/images/ProFormance_Toe_Klips_2G.jpg",
                    Price = (decimal)28,
                    Qty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 20,
                    Name = "Pro-Sport Dillo Shades",
                    Description = "This line is my preferred line coming down. 95% dry and/or grippy. Narrow in places and twisty througout, this leg churner is sure to keep you on you toes. This 40+ miles ride is packed full of stunning island views. Sign is posted at entrance.",
                    Image = "~/content/images/Pro_Sport_Dillo_Shades.jpg",
                    Price = (decimal)82,
                    Qty = 18,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 21,
                    Name = "Road Warrior Hitch Pack",
                    Description = "Amazing views of Castle valley are afforded after 50 meters of riding. Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride.",
                    Image = "~/content/images/Road_Warrior_Hitch_Pack.jpg",
                    Price = (decimal)175,
                    Qty = 6,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 22,
                    Name = "Shinoman 105 SC Brakes",
                    Description = "To the high point just before the intersection with Hooker Creek Trail. Small tree down between bottom of trail and bridge crossing. Technical singletrack. It's mostly a hike-a-bike up and then has an advanced all-mountain feel coming down.",
                    Image = "~/content/images/Shinoman_105_SC_Brakes.jpg",
                    Price = (decimal)23.50,
                    Qty = 16,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 23,
                    Name = "Shinoman Deluxe TX-30 Pedal",
                    Description = "Amazing views of Castle valley are afforded after 50 meters of riding. From Lake Imaging Road it is a steady but not steep climb to the high point. Built specifically for mountain bikes, a flow trail emphasizes speed and rhythm.",
                    Image = "~/content/images/Shinoman_Deluxe_TX_30_Pedal.jpg",
                    Price = (decimal)45,
                    Qty = 60,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 24,
                    Name = "Shinoman Dura-Ace Headset",
                    Description = "There is an optional drop 1/2 way down. Small tree down between bottom of trail and bridge crossing. Short and fast, with a few small jumps and some loose rocks. Stay straight when the trail intersects with a doubletrack and then bear left.",
                    Image = "~/content/images/Shinoman_Dura_Ace_Headset.jpg",
                    Price = (decimal)67.50,
                    Qty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 25,
                    Name = "StaDry Cycling Pants",
                    Description = "Other features include rock garden (that is rutted on the outer edges because XC peeps avoid it), skinny with twists and some other short elevated bridges. Brief passing showers are keeping it wet but the sun and wind are trying.",
                    Image = "~/content/images/StaDry_Cycling_Pants.jpg",
                    Price = (decimal)69,
                    Qty = 22,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 26,
                    Name = "TransPort Bicycle Rack",
                    Description = "For those that want to get tricksy, there are jumps littered throughout the trail as well. A long, long, did I mention long? Fire road that circles Mauna Kea. It is steep. A full suspension bike with 3+ inches of travel enhance your experience!",
                    Image = "~/content/images/TransPort_Bicycle_Rack.jpg",
                    Price = (decimal)27,
                    Qty = 14,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 27,
                    Name = "Trek 9000 Mountain Bike",
                    Description = "This 40+ miles ride is packed full of stunning island views. Be warned, this is not for the faint of heart! This ridge is more rugged than the other two ridges. Ride to the top and then down and link it directly into Ridegeline (with some double track).",
                    Image = "~/content/images/Trek_9000_Mountain_Bike.jpg",
                    Price = (decimal)1200,
                    Qty = 6,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 28,
                    Name = "True Grip Competition Gloves",
                    Description = "An awesome descent, with some high speed ripping at the top, some root drops in the middle, and some great bank turns at the bottom. Brief passing showers keep it wet. Parking at the bottom is near mile 12 of Palmer Fishhook Road.",
                    Image = "~/content/images/True_Grip_Competition_Gloves.jpg",
                    Price = (decimal)22,
                    Qty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 29,
                    Name = "Turbo Twin Tires",
                    Description = "The sun and wind are trying. Immediately the trail drops into medium rollers and doubles, winding it's way back down the mountain with steep downhills. Immediately the trail drops into medium rollers and doubles, winding it's way back down the mountain.",
                    Image = "~/content/images/Turbo_Twin_Tires.jpg",
                    Price = (decimal)29,
                    Qty = 18,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 30,
                    Name = "Ultimate Export 2G Car Rack",
                    Description = "For those that want to get tricksy, there are jumps littered throughout the trail as well. The area can be accessed from the end of Densmore's Lane, the end of Old Petty Harbour Road and from Huntingdale Drive.",
                    Image = "~/content/images/Ultimate_Export_2G_Car_Rack.jpg",
                    Price = (decimal)180,
                    Qty = 8,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 31,
                    Name = "Ultra-2K Competition Tire",
                    Description = "While it has no real technical features to speak of since being redesigned, it is a lot of fun to ride this glassy smooth and bermed trail. Kitsuma is a point to point singletrack trail that has a machine groomed tread.",
                    Image = "~/content/images/Ultra_2K_Competition_Tire.jpg",
                    Price = (decimal)34,
                    Qty = 22,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 32,
                    Name = "Ultra-Pro Rain Jacket",
                    Description = "They can be ridden in the winter depending on snow conditions. Proper sized jumps, berms, rollers and wooden features, so sick! Tree is elevated, so not rideable for most. I discovered this trail while out with my friend one day.",
                    Image = "~/content/images/Ultra_Pro_Rain_Jacket.jpg",
                    Price = (decimal)85,
                    Qty = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 33,
                    Name = "Victoria Pro All Weather Tires",
                    Description = "Lost Lake starts at its namesake trailhead. Plenty of kick ups, jumps, drops, and huge berms. Yes. Kick ups, jumps, drops, and huge berms. This line is my preferred line coming down. Big downed tree near the end of Lower Black.",
                    Image = "~/content/images/Victoria_Pro_All_Weather_Tires.jpg",
                    Price = (decimal)54.95,
                    Qty = 20,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 34,
                    Name = "Viscount C-500 Wireless Bike Computer",
                    Description = "Or with only moderate climbing involved these trails can keep almost anyone interested for hours. From Lake Imaging Road it is a steady not steep climb. Trails are drying out quickly. There are also several sections of slickrock.",
                    Image = "~/content/images/Viscount_C_500_Wireless_Bike_Computer.jpg",
                    Price = (decimal)49,
                    Qty = 30,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 35,
                    Name = "Viscount CardioSport Sport Watch",
                    Description = "Some wet/muddy creek crossings, but otherwise dry. A super fun freeride trail starting with the Pinkbike drop, an impressive 12' by 12' drop. As the valley begins to close, the route transitions to a section of open forest.",
                    Image = "~/content/images/Viscount_CardioSport_Sport_Watch.jpg",
                    Price = (decimal)179,
                    Qty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 36,
                    Name = "Viscount Microshell Helmet",
                    Description = "The descents are steep and tricky. The climb to the top ends with a beautiful vista of Twin Lakes and the surrounding area. There was enough rain. It's mostly a hike-a-bike up and then has an advanced all-mountain feel coming down.",
                    Image = "~/content/images/Viscount_Microshell_Helmet.jpg",
                    Price = (decimal)36,
                    Qty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 37,
                    Name = "Viscount Mountain Bike",
                    Description = "It's mostly a hike-a-bike up and then has an advanced all-mountain feel coming down. If you keep your momentum you can charge up all the climbs. The trail ends with some nice berms at the bottom. This line is my preferred line coming down.",
                    Image = "~/content/images/Viscount_Mountain_Bikes.jpg",
                    Price = (decimal)635,
                    Qty = 5,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 38,
                    Name = "Viscount Tru-Beat Heart Transmitter",
                    Description = "Or those that want to get tricksy, there are jumps littered throughout the trail as well. Trail is in good shape, minus dirt bikers dusting it up some. Sign is posted at entrance to warn userss.",
                    Image = "~/content/images/Viscount_Tru_Beat_Heart_Transmitter.jpg",
                    Price = (decimal)47,
                    Qty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 39,
                    Name = "Wonder Wool Cycle Socks",
                    Description = "Trail contains a rope-suspended ladder bridge, elevated bridges and a long-straight skinny. Then it is a gradual descent or flat on to the end of the trail at Hickory Mountain Road.",
                    Image = "~/content/images/Wonder_Wood_Cycle_Socks.jpg",
                    Price = (decimal)19,
                    Qty = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 40,
                    Name = "X-Pro All Weather Tires",
                    Description = "Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride. Logs embedded in the trail have been installed to signal technical terrain.",
                    Image = "~/content/images/X_Pro_All_Weather_Tires.jpg",
                    Price = (decimal)24,
                    Qty = 20,
                    CategoryID = 6
                }
            );

            modelBuilder.Entity<Vendor>().HasData(
                new Vendor
                {
                    VendorID = 1,
                    Name = "Shinoman, Incorporated",
                    Address = "3042 19th Avenue South",
                    City = "Bellevue",
                    State = "WA",
                    ZipCode = "98001",
                    PhoneNumber = "425-888-1234",
                    Email = "Sales@Shiniman.com"
                },
                new Vendor
                {
                    VendorID = 2,
                    Name = "Viscount",
                    Address = "1911 Commerce Way",
                    City = "St. Louis",
                    State = "MO",
                    ZipCode = "63127",
                    PhoneNumber = "314-777-1234",
                    Email = "Orders@ViscountBikes.com"
                },
                new Vendor
                {
                    VendorID = 3,
                    Name = "Nikoma of America",
                    Address = "88 Old North Road Ave",
                    City = "Ballard",
                    State = "WA",
                    ZipCode = "91324",
                    PhoneNumber = "206-666-1234",
                    Email = "BuyBikes@NikomaBikes.com"
                },
                new Vendor
                {
                    VendorID = 4,
                    Name = "ProFormance",
                    Address = "29 N. Quail St.",
                    City = "Albany",
                    State = "NY",
                    ZipCode = "12012",
                    PhoneNumber = "518-444-1234",
                    Email = "Sales@ProFormBikes.com"
                },
                new Vendor
                {
                    VendorID = 5,
                    Name = "Kona, Incorporated",
                    Address = "PO Box 10429",
                    City = "Redmond",
                    State = "WA",
                    ZipCode = "98052",
                    PhoneNumber = "425-333-1234",
                    Email = "Sales@KonaBikes.com"
                },
                new Vendor
                {
                    VendorID = 6,
                    Name = "Big Sky Mountain Bikes",
                    Address = "Glacier Bay South",
                    City = "Anchorage",
                    State = "AK",
                    ZipCode = "99209",
                    PhoneNumber = "907-222-1234",
                    Email = "Sales@BigSkyBikes.com"
                },
                new Vendor
                {
                    VendorID = 7,
                    Name = "Dog Ear",
                    Address = "575 Madison Ave.",
                    City = "New York",
                    State = "NY",
                    ZipCode = "10003",
                    PhoneNumber = "212-888-9876",
                    Email = "Sales@DogEar.com",
                },
                new Vendor
                {
                    VendorID = 8,
                    Name = "Sun Sports Suppliers",
                    Address = "PO Box 8082",
                    City = "Santa Monica",
                    State = "CA",
                    ZipCode = "91003",
                    PhoneNumber = "310-777-9876",
                    Email = "Sales@SunSports.com"
                },
                new Vendor
                {
                    VendorID = 9,
                    Name = "Lone Star Bike Supply",
                    Address = "7402 Kingman Drive",
                    City = "El Paso",
                    State = "TX",
                    ZipCode = "79915",
                    PhoneNumber = "915-666-9876",
                    Email = "Sales@LoneStarBikes.com"
                },
                new Vendor
                {
                    VendorID = 10,
                    Name = "Armadillo Brand",
                    Address = "12330 Side Road Lane",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75137",
                    PhoneNumber = "214-444-9876",
                    Email = "BikeProducts@DilloBikes.com"
                }
            );

        }


    }

    }

