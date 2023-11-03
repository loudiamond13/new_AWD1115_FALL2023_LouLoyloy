using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BikeShop_HOT.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Accessories" },
                    { 2, "Bikes" },
                    { 3, "Clothing" },
                    { 4, "Components" },
                    { 5, "Car racks" },
                    { 6, "Wheels" },
                    { 100, "Uncategorized Products" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "FirstName", "LastName", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "15127 NE 24th, #383", "Redmond", "Suzanne", "Viescas", "425-555-2686", "WA", "98052" },
                    { 2, "122 Spring River Drive", "Duvall", "William", "Thompson", "425-555-2681", "WA", "98019" },
                    { 3, "Route 2, Box 203B", "Auburn", "Gary", "Hallmark", "253-555-2676", "WA", "98013" },
                    { 4, "672 Lamont Ave", "Houston", "Robert", "Brown", "713-555-2491", "TX", "77201" },
                    { 5, "4110 Old Redmond Rd.", "Redmond", "Dean", "McCrae", "425-555-2506", "WA", "98052" },
                    { 6, "15127 NE 24th, #383", "Redmond", "John", "Viescas", "425-555-2511", "WA", "98052" },
                    { 7, "901 Pine Avenue", "Portland", "Mariya", "Sergienko", "503-555-2526", "OR", "97208" },
                    { 8, "233 West Valley Hwy", "San Diego", "Neil", "Patterson", "619-555-2541", "CA", "92199" },
                    { 9, "507 - 20th Ave. E. Apt. 2A", "Seattle", "Andrew", "Cencini", "206-555-2601", "WA", "98105" },
                    { 10, "667 Red River Road", "Austin", "Angel", "Kennedy", "512-555-2571", "TX", "78710" },
                    { 11, "Route 2, Box 203B", "Woodinville", "Alaina", "Hallmark", "425-555-2631", "WA", "98072" },
                    { 12, "13920 S.E. 40th Street", "Bellevue", "Liz", "Keyser", "425-555-2556", "WA", "98006" },
                    { 13, "2114 Longview Lane", "San Diego", "Rachel", "Patterson", "619-555-2546", "CA", "92199" },
                    { 14, "611 Alpine Drive", "Palm Springs", "Sam", "Abolrous", "760-555-2611", "CA", "92263" },
                    { 15, "2601 Seaview Lane", "Chico", "Darren", "Gehring", "530-555-2616", "CA", "95926" },
                    { 16, "101 NE 88th", "Salem", "Jim", "Wilson", "503-555-2636", "OR", "97301" },
                    { 17, "66 Spring Valley Drive", "Medford", "Manuela", "Seidel", "541-555-2641", "OR", "97501" },
                    { 18, "311 20th Ave. N.E.", "Fremont", "David", "Smith", "510-555-2646", "CA", "94538" },
                    { 19, "12330 Kingman Drive", "Glendale", "Zachary", "Ehrlich", "819-555-2721", "CA", "91209" },
                    { 20, "2424 Thames Drive", "Bellevue", "Joyce", "Bonnicksen", "425-555-2726", "WA", "98006" },
                    { 21, "2500 Rosales Lane", "Dallas", "Estella", "Pundt", "972-555-9938", "TX", "75260" },
                    { 22, "4501 Wetland Road", "Long Beach", "Caleb", "Viescas", "562-555-0037", "CA", "90809" },
                    { 23, "2343 Harmony Lane", "Seattle", "Julia", "Schnebly", "206-555-9936", "WA", "99837" },
                    { 24, "323 Advocate Lane", "El Paso", "Mark", "Rosales", "915-555-2286", "TX", "79915" },
                    { 25, "3445 Cheyenne Road", "El Paso", "Maria", "Patterson", "915-555-2291", "TX", "79915" },
                    { 26, "455 West Palm Ave", "San Antonio", "Kirk", "DeGrasse", "210-555-2311", "TX", "78284" },
                    { 27, "877 145th Ave SE", "Portland", "Luke", "Patterson", "503-555-2316", "OR", "97208" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "City", "FirstName", "LastName", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "16 Maple Lane", "Auburn", "Ann", "Patterson", "253-555-2591", "WA", "98002" },
                    { 2, "122 Spring River Drive", "Duvall", "Mary", "Thompson", "425-555-2516", "WA", "98019" },
                    { 3, "908 W. Capital Way", "Tacoma", "Matt", "Berg", "253-555-2581", "WA", "98413" },
                    { 4, "722 Moss Bay Blvd.", "Kirkland", "Carol", "Viescas", "425-555-2576", "WA", "98033" },
                    { 5, "16679 NE 42nd Court", "Redmond", "David", "Viescas", "425-555-2661", "WA", "98052" },
                    { 6, "455 West Palm Ave", "San Antonio", "Kirk", "DeGrasse", "210-555-2311", "TX", "78284" },
                    { 7, "554 E. Wilshire Apt. 2A", "Seattle", "Kathryn", "Patterson", "206-555-2697", "WA", "98105" },
                    { 8, "511 Lenora Ave", "Bellevue", "Susan", "McLain", "425-555-2301", "WA", "98006" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorID", "Address", "City", "Email", "Name", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "3042 19th Avenue South", "Bellevue", "Sales@Shiniman.com", "Shinoman, Incorporated", "425-888-1234", "WA", "98001" },
                    { 2, "1911 Commerce Way", "St. Louis", "Orders@ViscountBikes.com", "Viscount", "314-777-1234", "MO", "63127" },
                    { 3, "88 Old North Road Ave", "Ballard", "BuyBikes@NikomaBikes.com", "Nikoma of America", "206-666-1234", "WA", "91324" },
                    { 4, "29 N. Quail St.", "Albany", "Sales@ProFormBikes.com", "ProFormance", "518-444-1234", "NY", "12012" },
                    { 5, "PO Box 10429", "Redmond", "Sales@KonaBikes.com", "Kona, Incorporated", "425-333-1234", "WA", "98052" },
                    { 6, "Glacier Bay South", "Anchorage", "Sales@BigSkyBikes.com", "Big Sky Mountain Bikes", "907-222-1234", "AK", "99209" },
                    { 7, "575 Madison Ave.", "New York", "Sales@DogEar.com", "Dog Ear", "212-888-9876", "NY", "10003" },
                    { 8, "PO Box 8082", "Santa Monica", "Sales@SunSports.com", "Sun Sports Suppliers", "310-777-9876", "CA", "91003" },
                    { 9, "7402 Kingman Drive", "El Paso", "Sales@LoneStarBikes.com", "Lone Star Bike Supply", "915-666-9876", "TX", "79915" },
                    { 10, "12330 Side Road Lane", "Dallas", "BikeProducts@DilloBikes.com", "Armadillo Brand", "214-444-9876", "TX", "75137" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "Image", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 4, "Greens Lick is a machine built trail designed by Trail Dynamics as a demonstration trail showing the forest service how eroded road beds could be converted to sustainable trail.", "~/content/images/AeroFlo_ATB_Wheels.jpg", "AeroFlo ATB Wheels", 189m, 40 },
                    { 2, 1, "This trail can be sandy during dry summer months and is best after rain, in the spring or fall. Rocks for texture, obstacles for fun and some short fast downhils in this 2.", "~/content/images/Clear_Shade_85_T_Glasses.jpg", "Clear Shade 85-T Glasses", 45m, 14 },
                    { 3, 4, "If you keep your momentum you can charge up pretty much all the climbs and the descents are steep and tricky. Very loose and dry. Narrow in places and twisty througout.", "~/content/images/Cosmic_Elite_Road_Warrior_Wheels.jpg", "Cosmic Elite Road Warrior Wheels", 165m, 22 },
                    { 4, 1, "It has a number of blind LH corners so whistle or use a bell so you can alert anyone coming the opposite way. One of the best rides in all of tahoe.", "~/content/images/Cycle_Doc_Pro_Repair_Stand.jpg", "Cycle-Doc Pro Repair Stand", 166m, 12 },
                    { 5, 1, "From there the trail stretches out and travels pretty fast into a big berm with a view out into the valley. Use caution in the corners. Built specifically for mountain bikes.", "~/content/images/Dog_Ear_Aero_Flow_Floor_Pump.jpg", "Dog Ear Aero-Flow Floor Pump", 55m, 25 },
                    { 6, 1, "features that are designed in a way that uses the rider’s momentum to minimize pedaling and braking (think downhill pump track). Lots of opportunities for big air.", "~/content/images/Dog_Ear_Cycle_Computer.jpg", "Dog Ear Cycle Computer", 75m, 20 },
                    { 7, 1, "Winding trail with dips, climbs and descents. Wait a few days after any fresh snowfall and the entire area becomes one giant freeride trail after the shredders pack down the powder.", "~/content/images/Dog_Ear_Helmet_Mount_Mirror.jpg", "Dog Ear Helmet Mount Mirrors", 7.45m, 12 },
                    { 8, 1, "A flow trail emphasizes speed and rhythm, featuring berms, rollers, jumps and other features that are designed in a way that uses the rider’s momentum to minimize pedaling and braking.", "~/content/images/Dog_Ear_Monster_Grip_Gloves.jpg", "Dog Ear Monster Grip Gloves", 15m, 30 },
                    { 9, 2, "16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008, the State of Alaska installed a more user friendly course in 2012.", "~/content/images/Eagle_FS_3_Mountain_Bike.jpg", "Eagle FS-3 Mountain Bike", 1800m, 8 },
                    { 10, 4, "Formerly smooth as glass, it has taken on a very natural character with lots of rollers to soak up or jump. One of the best rides in all of tahoe.", "~/content/images/Eagle_SA_120_Clipless_Pedals.jpg", "Eagle SA-120 Clipless Pedals", 139.5m, 20 },
                    { 11, 1, "It is steep. Check your speed before rumbling over the wet armored section that make a tight right hand turn into a bridge. With moderate climbing involved.", "~/content/images/Glide_O_Matic_Cycling_Helmet.jpg", "Glide-O-Matic Cycling Helmet", 125m, 24 },
                    { 12, 2, "These trails can keep almost anyone interested for hours. The route begins at the end of Quid Pro Flow and an intersection with Three Thirty Eight.", "~/content/images/GT_RTS_2_Mountain_Bike.jpg", "GT RTS-2 Mountain Bike", 1650m, 5 },
                    { 13, 1, "MBoSC has partnered with land manager California Department of Forestry and Fire Protection (CAL FIRE) to build a four mile flow trail in Soquel Demonstration State Forest (SDSF).", "~/content/images/HP_Deluxe_Panniers.jpg", "HP Deluxe Panniers", 39m, 10 },
                    { 14, 1, "The area can be accessed from the end of Densmore's Lane, the end of Old Petty Harbour Road and from Huntingdale Drive. One of the best downhills in the area. Pretty dry and fast.", "~/content/images/King_Cobra_Helmet.jpg", "King Cobra Helmet", 139m, 30 },
                    { 15, 4, "There is an optional drop 1/2 way down. On the bike map it is often combined as the Whole Enchilada with Porcupine Rim, Kokopelli, Hazard County and Burro Pass.", "~/content/images/Kool_Breeze_Rocket_Top_Jersey.jpg", "Kool Breeze Rocket Top Jersey", 4.99m, 40 },
                    { 16, 1, "Great conditions today. Large group of trees down on northern section of trail, between buckhorn and club gap. Long pedal up form town but best when shuttled to the top.", "~/content/images/Kryptonite_Advanced_2000_U_Lock.jpg", "Kryptonite Advanced 2000 U-Lock", 50m, 20 },
                    { 17, 1, "Parking at the bottom is near mile 12 of Palmer Fishhook Road, while the top of the trailhead starts near mile 16 of Palmer Fishhook Road. You can find everyone out here having fun from people.", "~/content/images/Nikoma_Lok_Tight_U_Lock.jpg", "Nikoma Lok-Tight U-Lock", 33m, 12 },
                    { 18, 4, "If you continue, the trail ends at one of the lakes and continues lakeside until reaching the point where you began the trail The lake-side bit is fairly technical and very fun.", "~/content/images/ProFormance_ATB_All_Terrain_Pedal.jpg", "ProFormance ATB All-Terrain Pedal", 28m, 40 },
                    { 19, 4, "Narrow in places and twisty througout, this leg churner is sure to keep you on you toes. The area can be accessed from the end of Densmore's Lane, the end of Old Petty Harbour Road.", "~/content/images/ProFormance_Toe_Klips_2G.jpg", "ProFormance Toe Klips 2G", 28m, 40 },
                    { 20, 1, "This line is my preferred line coming down. 95% dry and/or grippy. Narrow in places and twisty througout, this leg churner is sure to keep you on you toes. This 40+ miles ride is packed full of stunning island views. Sign is posted at entrance.", "~/content/images/Pro_Sport_Dillo_Shades.jpg", "Pro-Sport Dillo Shades", 82m, 18 },
                    { 21, 5, "Amazing views of Castle valley are afforded after 50 meters of riding. Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride.", "~/content/images/Road_Warrior_Hitch_Pack.jpg", "Road Warrior Hitch Pack", 175m, 6 },
                    { 22, 4, "To the high point just before the intersection with Hooker Creek Trail. Small tree down between bottom of trail and bridge crossing. Technical singletrack. It's mostly a hike-a-bike up and then has an advanced all-mountain feel coming down.", "~/content/images/Shinoman_105_SC_Brakes.jpg", "Shinoman 105 SC Brakes", 23.5m, 16 },
                    { 23, 4, "Amazing views of Castle valley are afforded after 50 meters of riding. From Lake Imaging Road it is a steady but not steep climb to the high point. Built specifically for mountain bikes, a flow trail emphasizes speed and rhythm.", "~/content/images/Shinoman_Deluxe_TX_30_Pedal.jpg", "Shinoman Deluxe TX-30 Pedal", 45m, 60 },
                    { 24, 4, "There is an optional drop 1/2 way down. Small tree down between bottom of trail and bridge crossing. Short and fast, with a few small jumps and some loose rocks. Stay straight when the trail intersects with a doubletrack and then bear left.", "~/content/images/Shinoman_Dura_Ace_Headset.jpg", "Shinoman Dura-Ace Headset", 67.5m, 20 },
                    { 25, 3, "Other features include rock garden (that is rutted on the outer edges because XC peeps avoid it), skinny with twists and some other short elevated bridges. Brief passing showers are keeping it wet but the sun and wind are trying.", "~/content/images/StaDry_Cycling_Pants.jpg", "StaDry Cycling Pants", 69m, 22 },
                    { 26, 1, "For those that want to get tricksy, there are jumps littered throughout the trail as well. A long, long, did I mention long? Fire road that circles Mauna Kea. It is steep. A full suspension bike with 3+ inches of travel enhance your experience!", "~/content/images/TransPort_Bicycle_Rack.jpg", "TransPort Bicycle Rack", 27m, 14 },
                    { 27, 2, "This 40+ miles ride is packed full of stunning island views. Be warned, this is not for the faint of heart! This ridge is more rugged than the other two ridges. Ride to the top and then down and link it directly into Ridegeline (with some double track).", "~/content/images/Trek_9000_Mountain_Bike.jpg", "Trek 9000 Mountain Bike", 1200m, 6 },
                    { 28, 1, "An awesome descent, with some high speed ripping at the top, some root drops in the middle, and some great bank turns at the bottom. Brief passing showers keep it wet. Parking at the bottom is near mile 12 of Palmer Fishhook Road.", "~/content/images/True_Grip_Competition_Gloves.jpg", "True Grip Competition Gloves", 22m, 20 },
                    { 29, 6, "The sun and wind are trying. Immediately the trail drops into medium rollers and doubles, winding it's way back down the mountain with steep downhills. Immediately the trail drops into medium rollers and doubles, winding it's way back down the mountain.", "~/content/images/Turbo_Twin_Tires.jpg", "Turbo Twin Tires", 29m, 18 },
                    { 30, 5, "For those that want to get tricksy, there are jumps littered throughout the trail as well. The area can be accessed from the end of Densmore's Lane, the end of Old Petty Harbour Road and from Huntingdale Drive.", "~/content/images/Ultimate_Export_2G_Car_Rack.jpg", "Ultimate Export 2G Car Rack", 180m, 8 },
                    { 31, 6, "While it has no real technical features to speak of since being redesigned, it is a lot of fun to ride this glassy smooth and bermed trail. Kitsuma is a point to point singletrack trail that has a machine groomed tread.", "~/content/images/Ultra_2K_Competition_Tire.jpg", "Ultra-2K Competition Tire", 34m, 22 },
                    { 32, 3, "They can be ridden in the winter depending on snow conditions. Proper sized jumps, berms, rollers and wooden features, so sick! Tree is elevated, so not rideable for most. I discovered this trail while out with my friend one day.", "~/content/images/Ultra_Pro_Rain_Jacket.jpg", "Ultra-Pro Rain Jacket", 85m, 30 },
                    { 33, 6, "Lost Lake starts at its namesake trailhead. Plenty of kick ups, jumps, drops, and huge berms. Yes. Kick ups, jumps, drops, and huge berms. This line is my preferred line coming down. Big downed tree near the end of Lower Black.", "~/content/images/Victoria_Pro_All_Weather_Tires.jpg", "Victoria Pro All Weather Tires", 54.95m, 20 },
                    { 34, 1, "Or with only moderate climbing involved these trails can keep almost anyone interested for hours. From Lake Imaging Road it is a steady not steep climb. Trails are drying out quickly. There are also several sections of slickrock.", "~/content/images/Viscount_C_500_Wireless_Bike_Computer.jpg", "Viscount C-500 Wireless Bike Computer", 49m, 30 },
                    { 35, 1, "Some wet/muddy creek crossings, but otherwise dry. A super fun freeride trail starting with the Pinkbike drop, an impressive 12' by 12' drop. As the valley begins to close, the route transitions to a section of open forest.", "~/content/images/Viscount_CardioSport_Sport_Watch.jpg", "Viscount CardioSport Sport Watch", 179m, 12 },
                    { 36, 1, "The descents are steep and tricky. The climb to the top ends with a beautiful vista of Twin Lakes and the surrounding area. There was enough rain. It's mostly a hike-a-bike up and then has an advanced all-mountain feel coming down.", "~/content/images/Viscount_Microshell_Helmet.jpg", "Viscount Microshell Helmet", 36m, 20 },
                    { 37, 2, "It's mostly a hike-a-bike up and then has an advanced all-mountain feel coming down. If you keep your momentum you can charge up all the climbs. The trail ends with some nice berms at the bottom. This line is my preferred line coming down.", "~/content/images/Viscount_Mountain_Bikes.jpg", "Viscount Mountain Bike", 635m, 5 },
                    { 38, 1, "Or those that want to get tricksy, there are jumps littered throughout the trail as well. Trail is in good shape, minus dirt bikers dusting it up some. Sign is posted at entrance to warn userss.", "~/content/images/Viscount_Tru_Beat_Heart_Transmitter.jpg", "Viscount Tru-Beat Heart Transmitter", 47m, 20 },
                    { 39, 3, "Trail contains a rope-suspended ladder bridge, elevated bridges and a long-straight skinny. Then it is a gradual descent or flat on to the end of the trail at Hickory Mountain Road.", "~/content/images/Wonder_Wood_Cycle_Socks.jpg", "Wonder Wool Cycle Socks", 19m, 30 },
                    { 40, 6, "Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride. Logs embedded in the trail have been installed to signal technical terrain.", "~/content/images/X_Pro_All_Weather_Tires.jpg", "X-Pro All Weather Tires", 24m, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
