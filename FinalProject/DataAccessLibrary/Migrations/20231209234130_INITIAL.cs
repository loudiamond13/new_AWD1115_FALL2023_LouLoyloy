using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

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
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ProductColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productID);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Adidas" },
                    { 3, "Puma" },
                    { 4, "Crocs" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Shoes" },
                    { 2, "Hoodies/Pullovers" },
                    { 3, "Slides" },
                    { 4, "Caps" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "GenderName" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Unisex" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productID", "BrandID", "CategoryID", "GenderID", "ProductColor", "ProductDescription", "ProductImageURL", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 2, 4, 2, "Olive Strata", "When it's not cold enough for a beanie but you need a little extra protection, this adidas golf hat has you covered. It's made of sturdy twill with an insulated lining to keep you warm during chilly rounds. A moisture-absorbing sweatband keeps you dry and comfortable from first drive to final putt.", "~/content/images/adidas_cap_Insulated_Quilted_5-Panel_Hat_Green_HY5996_01_standard_W.jpeg", "Insulated Quilted 5 Panel Hat", 39.50m },
                    { 2, 2, 4, 3, "Black", "Look effortlessly cool in this adidas bucket hat. Whether you're making a fashion statement or just trying to keep the sun out of your eyes, this polyester hat is ideal for those who value utility as much as style. The best part is, when you're done wearing it you can fold it into its own carrying pouch, complete with a strap.\r\n\r\nMade with a series of recycled materials, and at least 40% recycled content, this product represents just one of our solutions to help end plastic waste.", "~/content/images/adidas_cap_Packable_Bucket_Hat_Black_GB4276_06_standard_W.jpeg", "Packable Bucket Hat", 32.50m },
                    { 3, 2, 4, 1, "Black", "This men's hat has low-key Trefoil style with an embroidered logo on the front. Made of washed canvas, the hat has a crushable, packable design and an adjustable back strap so you can personalize the fit.", "~/content/images/adidas_cap_Relaxed_Strap-Back_Hat_Black_BH7139_04_standard_W.jpeg", "Relaxed Strap-Back Hat", 32.50m },
                    { 4, 2, 4, 1, "White", "This men's hat has low-key Trefoil style with an embroidered logo on the front. Made of washed canvas, the hat has a crushable, packable design and an adjustable back strap so you can personalize the fit.", "~/content/images/adidas_cap_Relaxed_Strap-Back_Hat_White_BH7142_04_standard_W.jpeg", "White Relaxed Strap-Back Hat", 32.50m },
                    { 5, 2, 4, 2, "Linen Green", "This adidas cap works just as well with casual outfits as with workout gear. Subtly embroidered with flowing script, it adds just a touch of sporty detail to your look. It's made with cotton for a soft feel, while the sweatband mops up any moisture to keep you cool and comfortable.", "~/content/images/adidas_cap_Saturday_2.0_Plus_Hat_Silver_GB4331_06_standard_W.jpeg", "Saturday 2.0 Plus Hat", 33.00m },
                    { 6, 2, 4, 1, "Black", "Rain or shine, the trail still calls. Get in your run or make the hike happen in wet weather with this Terrex hat. adidas RAIN.RDY seals out water to keep you running, hiking or exploring — all while keeping your head dry. The seam-sealed design keeps it waterproof, while a moisture-wicking headband keeps sweat out of your face.", "~/content/images/adidas_cap_TERREX_RAIN.RDY_Cap_Black_HY3790_01_standard_W.jpeg", "TERREX RAIN.RDY Cap", 35.00m },
                    { 7, 2, 4, 1, "Blue", "Rain or shine, the trail still calls. Get in your run or make the hike happen in wet weather with this Terrex hat. adidas RAIN.RDY seals out water to keep you running, hiking or exploring — all while keeping your head dry. The seam-sealed design keeps it waterproof, while a moisture-wicking headband keeps sweat out of your face.", "~/content/images/adidas_cap_TERREX_RAIN_RDY_Cap_Blue_HY3791_01_standard_W.jpeg", "TERREX_RAIN_RDY Cap", 35.00m },
                    { 8, 2, 4, 1, "Black", "Fresh adidas Originals style for the streets. This six-panel cap combines a flat brim with a raised Trefoil logo embroidery. A snap-back closure lets you fine-tune the fit.", "~/content/images/adidas_cap_Trefoil_Chain_Snap-Back_Cap_Black_standard.jpeg", "Trefoil Chain Snap-Back Cap", 36.00m },
                    { 9, 2, 4, 1, "Black", "Sunny days are more fun under the brim of this adidas boonie hat. Not only does it shade your eyes, it also steps up your style. A zip pocket and adjustable chin strap seal the deal on utilitarian style. All that's left to do is to grab your towel and head to the beach.", "~/content/images/adidas_cap_Utility_Boonie_Hat_Black_GA5295_01_standard_W.jpeg", "Utility Boonie Hat", 50.00m },
                    { 10, 2, 4, 3, "Shadow Red", "There's nothing more timeless than a classic baseball hat. Throw on this adidas cap and bring some effortless style to any outfit. Its soft fleece build and 3D embroidered Badge of Sport give it that premium touch that elevates your look.", "~/content/images/adidas_cap_Wool_Baseball_Hat_Burgundy_IJ7300_01_standard_W.jpeg", "Wool Baseball Hat", 20.00m },
                    { 11, 2, 2, 1, "Black", "Got a cold-weather round in store? Game on. Pull on this adidas golf hoodie and you won't give the temperature a second thought. It's made with COLD.RDY that traps heat against the body to keep you warm in chilly conditions. Soft fleece feels extra cosiness against your skin, and a bungee-adjustable hem lets you seal out cool air. When light rain hits, you'll stay dry thanks to the water-repellent finish.", "~/content/images/adidas_COLD_RDY_Hoodie_Black_IL9632_21_mens.jpeg", "COLD RDY Hoodie", 71.00m },
                    { 12, 2, 2, 1, "Black/White", "When they go loud, you go low-key. This adidas hoodie has plenty of understated appeal. Made from cotton-blend fleece, it keeps you warm from your head to your hands, thanks to the adjustable hood and the cozy front pocket. 3-Stripes at the shoulders add a classic touch.", "~/content/images/adidas_Essentials_Fleece_3-Stripes_Full-Zip_Hoodie_Black_IB4029_21_mens.jpeg", "Essentials Fleece 3-Stripes Full-Zip Hoodie", 45.00m },
                    { 13, 2, 2, 1, "Grey", "When they go loud, you go low-key. This adidas hoodie has plenty of understated appeal. Made from cotton-blend fleece, it keeps you warm from your head to your hands, thanks to the adjustable hood and the cozy front pocket. 3-Stripes at the shoulders add a classic touch.", "~/content/images/adidas_Essentials_Fleece_3-Stripes_Full-Zip_Hoodie_Grey_IJ6479_21_mens.jpeg", "Essentials Fleece 3-Stripes Full-Zip Hoodie", 45.00m },
                    { 14, 2, 2, 1, "Black", "An everyday essential with an eye-catching graphic. The comfortable loose fit, French terry construction and classic silhouette make this adidas hoodie an instant go-to. Trefoil logos on the front and back get an elemental update with photorealistic water droplets that'll have passersby doing a double take.", "~/content/images/adidas_Graphic_Liquid_Trefoil_Hoodie_Black_II8170_21_mens.jpeg", "Graphic Liquid Trefoil Hoodie", 62.00m },
                    { 15, 2, 2, 3, "Black", "Whether it's chilly out or you just feel like hanging at home, this adidas hoodie lets you make the most out of a cold day. It's made of soft, heavyweight French terry fabric to keep you warm, and it's styled to be worn by all genders. The loose fit gives you a relaxed feel, so you can lounge around comfortably all day long.", "~/content/images/adidas_Lounge_Heavy_French_Terry_Hoodie_Black_IC4084_25_mens.jpeg", "Lounge Heavy French Terry Hoodie", 99.00m },
                    { 16, 2, 2, 1, "Arctic Night", "Stand out from tee to green in this adidas golf sweatshirt. Soft polar fleece gives a luxe feel while keeping you cozy on the course during chilly weather. Ribbed cuffs and hem seal out the cold, and a durable water-repellent finish keeps you dry through misty rounds and occasional light showers.", "~/content/images/adidas_Oasis_Crew_Sweatshirt_Turquoise_IB1982_21_mens.jpeg", "Oasis Crew Sweatshirt Turquoise", 99.00m },
                    { 17, 2, 2, 1, "Bright Red", "Chilly weather calls for a lightweight layer. This adidas golf pullover is made of soft knit for comfort on the course. Moisture-absorbing AEROREADY keeps you dry, and built-in UV coverage lets you play with confidence on sunny days.", "~/content/images/adidas_Quarter-Zip_Pullover_Red_IJ0185_25_mens.jpeg", "Quarter-Zip Pullover", 47.00m },
                    { 18, 2, 2, 1, "Blue / White", "Sometimes less is more. The adidas Trefoil Essentials crewneck perfects effortless style and timeless design. An embroidered Trefoil adorns the clean silhouette. Made for everyday casual wear, this crewneck serves laid-back vibes with a simple yet bold look.", "~/content/images/adidas_Trefoil_Essentials_Crewneck_Blue_IR7781_21_mens.jpeg", "Trefoil Essentials Crewneck", 41.00m },
                    { 19, 2, 2, 1, "Black", "Whether you're on the mat in the studio or at home, this super-soft adidas sweatshirt lets you breathe easily. Perfect your poses in its free-flowing design, detailed with a hood, a zip pocket and shaped cuffs. In the mood for hot yoga? AEROREADY manages moisture so you can keep your focus. The back relays a message to remember: Allow yourself to grow.", "~/content/images/adidas_Yoga_Training_Hooded_Sweatshirt_Black_IN7922_21_mens.jpeg", "Yoga Training Hooded Sweatshirt", 51.00m },
                    { 20, 2, 2, 1, "Dark Grey Heather", "When they go loud, you go low-key. This adidas hoodie has plenty of understated appeal. Made from cotton-blend fleece, it keeps you warm from your head to your hands, thanks to the adjustable hood and the cozy front pocket. 3-Stripes at the shoulders add a classic touch.", "~/content/images/adidas_Essentials_Fleece_3-Stripes_Full-Zip_Hoodie_Grey_IJ6480_21_mens.jpeg", "Essentials Fleece 3-Stripes Full-Zip Hoodie", 48.00m },
                    { 21, 1, 1, 1, "Night Stadium/Black/Flat Pewter/Total Orange", "Clean and supreme, the AJ3 returns with all of its classic style and grace. Quality leather in the upper—with that luxurious elephant print texture—combines with visible Nike Air in the sole to make a comfortable, everyday icon.", "~/content/images/Air_Jordan_3_Fear.jpg", "Air Jordan 3 Fear", 211.00m },
                    { 22, 1, 1, 1, "White/Black/White/Royal Blue", "Inspired by the original that debuted in 1985, the Air Jordan 1 Low offers a clean, classic look that's familiar yet always fresh. With an iconic design that pairs perfectly with any 'fit, these kicks ensure you'll always be on point.", "~/content/images/AirJordan_1_Low.jpg", "Air Jordan 1 Low", 116.00m },
                    { 23, 1, 1, 1, "White/Midnight Navy/Black", "Feel unbeatable, from the tee box to the final putt. Inspired by one of the most iconic sneakers of all time, the Air Jordan 1 G is an instant classic on the course. With Air cushioning underfoot, a Wings logo on the heel and an integrated traction pattern to help you power through your swing, it delivers all the clubhouse cool of the original AJ1—plus everything you need to play 18 holes in comfort.", "~/content/images/AirJordan_1_Low_G.jpg", "Air Jordan 1 Low G", 155.00m },
                    { 24, 1, 1, 1, "White/Black/Gym Red", "Inspired by the original AJ1, this mid-top edition maintains the iconic look you love while choice colors and crisp leather give it a distinct identity.", "~/content/images/AirJordan_1_Mid_Red.jpg", "Air Jordan 1 Mid Red", 130.00m },
                    { 25, 1, 1, 1, "White", "Inspired by the original AJ1, the Air Jordan 1 Mid offers fans a chance to follow in MJ's footsteps. Fresh color trims the clean, classic materials, imbuing modernity into a classic design.", "~/content/images/AirJordan_1_Mid_White.jpg", "Air Jordan 1 Mid White", 131.00m },
                    { 26, 1, 1, 1, "Light Orewood Brown/Sail/Celestial Gold/Bright Citrus", "Premium suede and Jordan Brand's signature Formula 23 foam come together to give you an extra luxurious (and extra cozy) AJ1. You don't need to play \"either or\" when it comes to choosing style or comfort with this one—which is nice, 'cause you deserve both.", "~/content/images/AirJordan_1_Zoom_CMFT_2.jpg", "Air Jordan 1 Zoom CMFT 2", 132.00m },
                    { 27, 1, 1, 1, "White/Black", "From us, to you—this release of the AJ11 is a \"Thank You\" to our day ones and those committed to carrying the Jordan legacy forward. Celebrating a heritage colorway, this classic honors MJ's legacy while elevating the materials for those pushing culture to new heights. The upper is designed with a mix of premium materials like luxe leather, along with a smooth knit collar. The glossy patent leather mudguard gleams just like the original. A tinted translucent outsole offers a clean finish while the welded gold Jumpman radiates the shoe's championship roots.", "~/content/images/AirJordan_11_Gratitude.jpg", "Air Jordan 11 Gratitude", 300.00m },
                    { 28, 1, 1, 1, "White/Wheat", "Celebrate 25 years of the AJ13 with a colorway bring-back. Dimpled full-grain White leather gets a soft, synthetic Wheat suede treatment for a boost of elegance. Capping it off, the green cat's eye emblem on the heel and panther paw-inspired outsole honor MJ's slick \"Black Cat\" alter ego.", "~/content/images/AirJordan_13_Wheat.jpg", "Air Jordan 13 Wheat", 200.00m },
                    { 29, 1, 1, 1, "Medium Olive/Cargo Khaki/Black/Pale Vanilla", "Here's the '89 classic, done up in elegant earth tones. Suede, leather and textiles come together in the upper for a truly textured look. And of course, all your favorite AJ4 elements are there too—like the floating eyestays and mesh-inspired side panels.", "~/content/images/AirJordan_4_Craft_Olive.jpg", "Air Jordan 4 Craft Olive", 210.00m },
                    { 30, 1, 1, 1, "Black/Metallic Silver/Gunsmoke", "Your cold-weather kicks have arrived. This AJ8 is designed with luxe leather, reflective elements and premium suede for durable style you can put to the test. Black and Gunsmoke pair with Metallic Silver for sleek seasonal style. It's an icy look that feels cool, whether it's winter or not.", "~/content/images/AirJordan_8_Winterized.jpg", "Air Jordan 8 Winterized", 210.00m },
                    { 31, 1, 2, 2, "Velvet Brown", "Cozy, but make it cool. This roomy, easy-fitting crew features mid-weight fleece for a soft feel. Combine that with elevated finishing touches and you have an everyday staple that truly stands out.", "~/content/images/nike_jordan-brooklyn-fleece-womens-crewneck-sweatshirt-zvZ5ms.jpg", "Nike Jordan Brooklyn fleece crewneck sweatshirt", 210.00m },
                    { 32, 1, 2, 2, "Red Stardust", "Meet your new favorite sweatshirt. The one you pull out of the dirty clothes pile because it’s too good not to wear one more time. (No one’s gonna know.) Super soft with a slightly oversized fit and extra volume in the sleeves, it's easy to pull on and perfect for layering.", "~/content/images/nike_jordan-flight-fleece-womens-crewneck-sweatshirt-rtRM9K.jpg", "Jordan flight fleece crewneck sweatshirt", 88.00m },
                    { 33, 1, 2, 2, "Black Heather", "Get cozy in a classic hoodie. Featuring a slightly fuzzy, heavyweight fleece in a roomy fit, you'll brave the cold in style. Satin lining on the hood means you can add coverage without worrying about your hair.", "~/content/images/nike_jordan-flight-fleece-womens-winterized-hoodie-CGbKGT.jpg", "Jordan flight fleece winterized hoodie", 108.00m },
                    { 34, 1, 2, 2, "Rugged Orange/Black", "Rise up and transform your wardrobe with strong cozy vibes. You're sure to fall in love with the soft feel of brushed fleece, while the roomy design of this cardigan makes you feel—and look—stylishly carefree.", "~/content/images/nike_Sportswear_Phoenix_fleece.jpg", "Nike Sportswear Phoenix fleece", 110.00m },
                    { 35, 1, 2, 2, "Diffused Blue/White", "Club Fleece sweatshirts, universally loved for their coziness and consistency, are for everyone. Always soft and made with a relaxed fit, they’re basics that help you do more. An essential for cold-weather layering, this crew-neck option is a quick and easy way to add warmth to your favorite puffer or jacket.", "~/content/images/nike_sportswear-club-fleece-womens-crew-neck-sweatshirt-plus-size-DtqkgP.jpg", "Nike Sportswear Club Fleece Crewneck Sweatshirt", 40.00m },
                    { 36, 1, 2, 2, "Fireberry/White", "Club Fleece sweatshirts, universally loved for their coziness and consistency, are for everyone. Always soft and made with a relaxed fit, they’re basics that help you do more. An essential for cold weather, this cozy pullover has just enough room to layer comfortably without feeling too big.", "~/content/images/nike_sportswear-club-fleece-womens-logo-pullover-hoodie-07xm3D.jpg", "Nike Sportswear Club Fleece", 80.00m },
                    { 37, 1, 2, 2, "Ale Brown/Cacao Wow", "This easy-fitting hoodie pairs soft fleece with tape-lined sleeves for a fresh-off-the-track finish. Smooth on the outside, slightly fuzzy on the inside, our midweight semi-brushed fleece helps keep you cozy while still being breezy. It’s a comfy layer to wear year-round, perfect for those tricky in-between temps.", "~/content/images/nike_sportswear-essential-womens-fleece-hoodie-4803DS.jpg", "Nike Sportswear Essential", 81.00m },
                    { 38, 1, 2, 2, "Midnight Navy/Black", "Grounded in style, comfort and versatility, meet our take on luxury loungewear. Our roomiest fit paired with exaggerated details (like the oversized pocket and taller ribbing) ensures this sweatshirt is anything but basic. All that's left to decide is whether to style it with the matching shorts or other pieces from your wardrobe.", "~/content/images/nike_sportswear-phoenix-fleece-womens-over-oversized-crew-neck-sweatshirt-nTshQw.jpg", "Nike Sportswear Phoenix Fleece", 81.00m },
                    { 39, 1, 2, 2, "Anthracite", "Rise up and transform your fleece wardrobe with strong cozy vibes. Our midweight brushed fleece feels extra soft on the inside and smooth on the outside, helping you stay comfortable while keeping its structured shape. With a washed aesthetic and exaggerated details, this crew-neck sweatshirt gives you a broken-in look that's anything but basic.", "~/content/images/nike_sportswear-phoenix-fleece-womens-oversized-crew-neck-sweatshirt-wbNcml.jpg", "Nike Sportswear Phoenix Fleece", 90.00m },
                    { 40, 1, 2, 2, "Midnight Navy/Black", "Grounded in style, comfort and versatility, meet our take on luxury loungewear. This classic hoodie helps you stay cozy all day long, thanks to midweight fleece that feels soft yet structured. Plus, exaggerated details (like taller ribbing and oversized fit) give you a trend-right look.", "~/content/images/nike_sportswear-phoenix-fleece-womens-oversized-pullover-hoodie-QnWVHw.jpg", "Nike Sportswear Phoenix Fleece", 75.00m },
                    { 41, 4, 3, 1, "Espresso", "Travel. Exploration. Adventures near and far. The look and feel of our Classic All-Terrain Clog, now in sandal form. With a more rugged outsole, two upper straps and an adjustable turbo strap, the ground beneath your feet has never felt more surmountable. Seven holes on each sandal allow for personalization with Jibbitz™ charms and a lightweight Croslite™ construction makes them a practical and packable choice for any outing. It's time to shift into all-wheel drive. Flip that strap back and go find your fun!", "~/content/images/p_crocs_mens_ALL_TERRAIN_SUMMIT_SANDAL.jpeg", "ALL TERRAIN SUMMIT SANDAL", 29.00m },
                    { 42, 4, 3, 1, "Bone / Multi", "The comfortable Classic Crocs Sandal now sports our new marbled Croslite™ material that creates a fun, colorful effect. While all marbled sandals have the same wavy look, no two are exactly alike. Enjoy iconic Crocs comfort and stylish design in this unique casual sandal that’s perfect for everyday wear.", "~/content/images/p_crocs_mens_CLASSIC_CROCS_MARBLED_SANDAL.jpeg", "CLASSIC CROCS MARBLED SANDAL", 31.00m },
                    { 43, 4, 3, 1, "Bone", "Original. Customizable. Comfortable. The ever-comfortable Classic II Slide gets the customization upgrade fans have been asking for in the Classic Crocs Slide: holes for Jibbitz™ charms! Each slide has room for 13 charms so you can load up your sandals with tons of personality. Original Croslite™ foam cushion will keep you comfortably supported from the beach to backyard gatherings and beyond. Choose your color and slide into a new favorite!", "~/content/images/P_crocs_mens_classic_slide.jpeg", "Crocs Classic Slides", 31.00m },
                    { 44, 4, 3, 1, "Bone", "All Flip, No Flop! Sporty and lightweight with the signature athletic stripe, the Crocband™ Flip is a colorful and incredibly comfortable warm-weather choice that pairs perfectly with shorts, slacks or swimwear. Constructed of easy-to-clean Croslite™ material, it’s ready for the beach, garden or anywhere else you choose to get your summer on!", "~/content/images/p_crocs_mens_crocband_flip.jpeg", "Crocband Flip", 31.00m },
                    { 45, 4, 3, 1, "Flame / White", "Enjoy the ever-comfortable Classic Crocs Slide now available in with a marbled effect. While all shoes have the same wavy look, no two are exactly alike, so you’ll have a completely unique pair. This special slide also features the Croslite™ footbed you love for an enjoyable ride. Choose your color and slide into a new favorite!", "~/content/images/p_mens_crocs_CLASSIC_CROCS_MARBLED_SLIDE.jpeg", "CLASSIC CROCS MARBLED SLIDE", 31.00m },
                    { 46, 4, 3, 1, "Puma Black-High Rise", "Streetwear, meet beachwear. The RS-Sandal takes the signature RS style for a ride with future-forward.", "~/content/images/puma_mens_black_RS-Sandal.jpeg", "Puma RS-Sandal", 54.00m },
                    { 47, 4, 3, 1, "Black", "Slip into extreme comfort and set the trend with the new Shibui Cat Sandals from PUMA. These cozy kicks come with a fully injected IMEVA slide for a perfectly snug feel at home or wherever your feet may carry you. Minimalist PUMA Cat Logo branding adds a smooth finish.", "~/content/images/puma_mens_Shibui-Cat-Slides.jpeg", "Shibui Cat Slides", 24.99m },
                    { 48, 4, 3, 1, "Marshmallow-Puma Black", "Streetwear, meet beachwear. The RS-Sandal takes the signature RS style for a ride with future-forward detailing and ultra-cushioned RS tech.", "~/content/images/puma_mens_RS-Sandal.jpeg", "RS-Sandal", 54.99m },
                    { 49, 4, 3, 1, "Puma Black-Puma White", "Prioritize comfort without sacrificing style in these on-trend Softride slides. Whether you’re cooling down after a workout or rocking a casual summertime look, this footwear is designed to provide the best underfoot cushioning. The Softride footbed ensures every step you take feels sumptuous, while the durable synthetic strap is adjustable, guaranteeing the snuggest fit.", "~/content/images/puma_mens_Softride-Slides.jpeg", "Softride Slides", 39.99m },
                    { 50, 4, 3, 1, "White", "Prioritize comfort without sacrificing style in these on-trend Softride slides. Whether you’re cooling down after a workout or rocking a casual summertime look, this footwear is designed to provide the best underfoot cushioning. The Softride footbed ensures every step you take feels sumptuous, while the durable synthetic strap is adjustable, guaranteeing the snuggest fit.", "~/content/images/puma_mens_white_Softride-Slides.jpeg", "Softride Slides", 39.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandID",
                table: "Products",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenderID",
                table: "Products",
                column: "GenderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
