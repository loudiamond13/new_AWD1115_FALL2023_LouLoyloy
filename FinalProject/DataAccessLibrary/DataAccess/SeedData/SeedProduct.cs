using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.SeedData
{
    internal class SeedProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasData(
                //brand
                // 1 = nike
                // 2 = adidas
                // 3 = puma
                // 4 = crocs

                //category
                // 1 = Shoes
                // 2 = Hoodies
                // 3 = Slides
                // 4 = Caps
                new Product 
                {
                    productID = 1,
                    ProductName = "Insulated Quilted 5 Panel Hat (Womens)",
                    ProductPrice = 39.50M,
                    ProductDescription = "When it's not cold enough for a beanie but you need a little extra protection, this adidas golf hat has you covered. It's made of sturdy twill with an insulated lining to keep you warm during chilly rounds. A moisture-absorbing sweatband keeps you dry and comfortable from first drive to final putt.",
                    GenderID = 2,
                    BrandID = 2,
                    CategoryID = 4,
                    ProductColor = "Olive Strata",
                    ProductImageURL = "~/content/images/adidas_cap_Insulated_Quilted_5-Panel_Hat_Green_HY5996_01_standard_W.jpeg"
                },
                  new Product
                  {
                      productID = 2,
                      ProductName = "Packable Bucket Hat (Unisex)",
                      ProductPrice = 32.50M,
                      ProductDescription = "Look effortlessly cool in this adidas bucket hat. Whether you're making a fashion statement or just trying to keep the sun out of your eyes, this polyester hat is ideal for those who value utility as much as style. The best part is, when you're done wearing it you can fold it into its own carrying pouch, complete with a strap.\r\n\r\nMade with a series of recycled materials, and at least 40% recycled content, this product represents just one of our solutions to help end plastic waste.",
                      GenderID = 3,
                      BrandID = 2,
                      CategoryID = 4,
                      ProductColor = "Black",
                      ProductImageURL = "~/content/images/adidas_cap_Packable_Bucket_Hat_Black_GB4276_06_standard_W.jpeg"
                  },
                  new Product
                  {
                      productID = 3,
                      ProductName = "Relaxed Strap-Back Hat (Mens)",
                      ProductPrice = 32.50M,
                      ProductDescription = "This men's hat has low-key Trefoil style with an embroidered logo on the front. Made of washed canvas, the hat has a crushable, packable design and an adjustable back strap so you can personalize the fit.",
                      GenderID = 1,
                      BrandID = 2,
                      CategoryID = 4,
                      ProductColor = "Black",
                      ProductImageURL = "~/content/images/adidas_cap_Relaxed_Strap-Back_Hat_Black_BH7139_04_standard_W.jpeg"
                  },
                   new Product
                   {
                       productID = 4,
                       ProductName = "White Relaxed Strap-Back Hat (Mens)",
                       ProductPrice = 32.50M,
                       ProductDescription = "This men's hat has low-key Trefoil style with an embroidered logo on the front. Made of washed canvas, the hat has a crushable, packable design and an adjustable back strap so you can personalize the fit.",
                       GenderID = 1,
                       BrandID = 2,
                       CategoryID = 4,
                       ProductColor = "White",
                       ProductImageURL = "~/content/images/adidas_cap_Relaxed_Strap-Back_Hat_White_BH7142_04_standard_W.jpeg"
                   },
                    new Product
                    {
                        productID = 5,
                        ProductName = "Saturday 2.0 Plus Hat (Womens)",
                        ProductPrice = 33.00M,
                        ProductDescription = "This adidas cap works just as well with casual outfits as with workout gear. Subtly embroidered with flowing script, it adds just a touch of sporty detail to your look. It's made with cotton for a soft feel, while the sweatband mops up any moisture to keep you cool and comfortable.",
                        GenderID = 2,
                        BrandID = 2,
                        CategoryID = 4,
                        ProductColor = "Linen Green",
                        ProductImageURL = "~/content/images/adidas_cap_Saturday_2.0_Plus_Hat_Silver_GB4331_06_standard_W.jpeg"
                    },
                    new Product
                    {
                        productID = 6,
                        ProductName = "TERREX RAIN.RDY Cap (Mens)",
                        ProductPrice = 35.00M,
                        ProductDescription = "Rain or shine, the trail still calls. Get in your run or make the hike happen in wet weather with this Terrex hat. adidas RAIN.RDY seals out water to keep you running, hiking or exploring — all while keeping your head dry. The seam-sealed design keeps it waterproof, while a moisture-wicking headband keeps sweat out of your face.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 4,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_cap_TERREX_RAIN.RDY_Cap_Black_HY3790_01_standard_W.jpeg"
                    },
                    new Product
                    {
                        productID = 7,
                        ProductName = "TERREX_RAIN_RDY Cap (Mens)",
                        ProductPrice = 35.00M,
                        ProductDescription = "Rain or shine, the trail still calls. Get in your run or make the hike happen in wet weather with this Terrex hat. adidas RAIN.RDY seals out water to keep you running, hiking or exploring — all while keeping your head dry. The seam-sealed design keeps it waterproof, while a moisture-wicking headband keeps sweat out of your face.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 4,
                        ProductColor = "Blue",
                        ProductImageURL = "~/content/images/adidas_cap_TERREX_RAIN_RDY_Cap_Blue_HY3791_01_standard_W.jpeg"
                    },
                    new Product
                    {
                        productID = 8,
                        ProductName = "Trefoil Chain Snap-Back Cap (Mens)",
                        ProductPrice = 36.00M,
                        ProductDescription = "Fresh adidas Originals style for the streets. This six-panel cap combines a flat brim with a raised Trefoil logo embroidery. A snap-back closure lets you fine-tune the fit.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 4,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_cap_Trefoil_Chain_Snap-Back_Cap_Black_standard.jpeg"
                    },
                    new Product
                    {
                        productID = 9,
                        ProductName = "Utility Boonie Hat (Mens)",
                        ProductPrice = 50.00M,
                        ProductDescription = "Sunny days are more fun under the brim of this adidas boonie hat. Not only does it shade your eyes, it also steps up your style. A zip pocket and adjustable chin strap seal the deal on utilitarian style. All that's left to do is to grab your towel and head to the beach.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 4,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_cap_Utility_Boonie_Hat_Black_GA5295_01_standard_W.jpeg"
                    },
                    new Product
                    {
                        productID = 10,
                        ProductName = "Wool Baseball Hat (Unisex)",
                        ProductPrice = 20.00M,
                        ProductDescription = "There's nothing more timeless than a classic baseball hat. Throw on this adidas cap and bring some effortless style to any outfit. Its soft fleece build and 3D embroidered Badge of Sport give it that premium touch that elevates your look.",
                        GenderID = 3,
                        BrandID = 2,
                        CategoryID = 4,
                        ProductColor = "Shadow Red",
                        ProductImageURL = "~/content/images/adidas_cap_Wool_Baseball_Hat_Burgundy_IJ7300_01_standard_W.jpeg"
                    },
                    new Product
                    {
                        productID = 11,
                        ProductName = "COLD RDY Hoodie (Mens)",
                        ProductPrice = 71.00M,
                        ProductDescription = "Got a cold-weather round in store? Game on. Pull on this adidas golf hoodie and you won't give the temperature a second thought. It's made with COLD.RDY that traps heat against the body to keep you warm in chilly conditions. Soft fleece feels extra cosiness against your skin, and a bungee-adjustable hem lets you seal out cool air. When light rain hits, you'll stay dry thanks to the water-repellent finish.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_COLD_RDY_Hoodie_Black_IL9632_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 12,
                        ProductName = "Essentials Fleece 3-Stripes Full-Zip Hoodie (Mens)",
                        ProductPrice = 45.00M,
                        ProductDescription = "When they go loud, you go low-key. This adidas hoodie has plenty of understated appeal. Made from cotton-blend fleece, it keeps you warm from your head to your hands, thanks to the adjustable hood and the cozy front pocket. 3-Stripes at the shoulders add a classic touch.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Black/White",
                        ProductImageURL = "~/content/images/adidas_Essentials_Fleece_3-Stripes_Full-Zip_Hoodie_Black_IB4029_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 13,
                        ProductName = "Essentials Fleece 3-Stripes Full-Zip Hoodie (Mens)",
                        ProductPrice = 45.00M,
                        ProductDescription = "When they go loud, you go low-key. This adidas hoodie has plenty of understated appeal. Made from cotton-blend fleece, it keeps you warm from your head to your hands, thanks to the adjustable hood and the cozy front pocket. 3-Stripes at the shoulders add a classic touch.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Grey",
                        ProductImageURL = "~/content/images/adidas_Essentials_Fleece_3-Stripes_Full-Zip_Hoodie_Grey_IJ6479_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 14,
                        ProductName = "Graphic Liquid Trefoil Hoodie (Mens)",
                        ProductPrice = 62.00M,
                        ProductDescription = "An everyday essential with an eye-catching graphic. The comfortable loose fit, French terry construction and classic silhouette make this adidas hoodie an instant go-to. Trefoil logos on the front and back get an elemental update with photorealistic water droplets that'll have passersby doing a double take.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_Graphic_Liquid_Trefoil_Hoodie_Black_II8170_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 15,
                        ProductName = "Lounge Heavy French Terry Hoodie (Unisex)",
                        ProductPrice = 99.00M,
                        ProductDescription = "Whether it's chilly out or you just feel like hanging at home, this adidas hoodie lets you make the most out of a cold day. It's made of soft, heavyweight French terry fabric to keep you warm, and it's styled to be worn by all genders. The loose fit gives you a relaxed feel, so you can lounge around comfortably all day long.",
                        GenderID = 3,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_Lounge_Heavy_French_Terry_Hoodie_Black_IC4084_25_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 16,
                        ProductName = "Oasis Crew Sweatshirt Turquoise (Mens)",
                        ProductPrice = 99.00M,
                        ProductDescription = "Stand out from tee to green in this adidas golf sweatshirt. Soft polar fleece gives a luxe feel while keeping you cozy on the course during chilly weather. Ribbed cuffs and hem seal out the cold, and a durable water-repellent finish keeps you dry through misty rounds and occasional light showers.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Arctic Night",
                        ProductImageURL = "~/content/images/adidas_Oasis_Crew_Sweatshirt_Turquoise_IB1982_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 17,
                        ProductName = "Quarter-Zip Pullover (Mens)",
                        ProductPrice = 47.00M,
                        ProductDescription = "Chilly weather calls for a lightweight layer. This adidas golf pullover is made of soft knit for comfort on the course. Moisture-absorbing AEROREADY keeps you dry, and built-in UV coverage lets you play with confidence on sunny days.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Bright Red",
                        ProductImageURL = "~/content/images/adidas_Quarter-Zip_Pullover_Red_IJ0185_25_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 18,
                        ProductName = "Trefoil Essentials Crewneck (Mens)",
                        ProductPrice = 41.00M,
                        ProductDescription = "Sometimes less is more. The adidas Trefoil Essentials crewneck perfects effortless style and timeless design. An embroidered Trefoil adorns the clean silhouette. Made for everyday casual wear, this crewneck serves laid-back vibes with a simple yet bold look.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Blue / White",
                        ProductImageURL = "~/content/images/adidas_Trefoil_Essentials_Crewneck_Blue_IR7781_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 19,
                        ProductName = "Yoga Training Hooded Sweatshirt (Mens)",
                        ProductPrice = 51.00M,
                        ProductDescription = "Whether you're on the mat in the studio or at home, this super-soft adidas sweatshirt lets you breathe easily. Perfect your poses in its free-flowing design, detailed with a hood, a zip pocket and shaped cuffs. In the mood for hot yoga? AEROREADY manages moisture so you can keep your focus. The back relays a message to remember: Allow yourself to grow.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/adidas_Yoga_Training_Hooded_Sweatshirt_Black_IN7922_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 20,
                        ProductName = "Essentials Fleece 3-Stripes Full-Zip Hoodie (Mens)",
                        ProductPrice = 48.00M,
                        ProductDescription = "When they go loud, you go low-key. This adidas hoodie has plenty of understated appeal. Made from cotton-blend fleece, it keeps you warm from your head to your hands, thanks to the adjustable hood and the cozy front pocket. 3-Stripes at the shoulders add a classic touch.",
                        GenderID = 1,
                        BrandID = 2,
                        CategoryID = 2,
                        ProductColor = "Dark Grey Heather",
                        ProductImageURL = "~/content/images/adidas_Essentials_Fleece_3-Stripes_Full-Zip_Hoodie_Grey_IJ6480_21_mens.jpeg"
                    },
                    new Product
                    {
                        productID = 21,
                        ProductName = "Air Jordan 3 Fear (Mens)",
                        ProductPrice = 211.00M,
                        ProductDescription = "Clean and supreme, the AJ3 returns with all of its classic style and grace. Quality leather in the upper—with that luxurious elephant print texture—combines with visible Nike Air in the sole to make a comfortable, everyday icon.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "Night Stadium/Black/Flat Pewter/Total Orange",
                        ProductImageURL = "~/content/images/Air_Jordan_3_Fear.jpg"
                    },
                    new Product
                    {
                        productID = 22,
                        ProductName = "Air Jordan 1 Low (Mens)",
                        ProductPrice = 116.00M,
                        ProductDescription = "Inspired by the original that debuted in 1985, the Air Jordan 1 Low offers a clean, classic look that's familiar yet always fresh. With an iconic design that pairs perfectly with any 'fit, these kicks ensure you'll always be on point.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "White/Black/White/Royal Blue",
                        ProductImageURL = "~/content/images/AirJordan_1_Low.jpg"
                    },
                    new Product
                    {
                        productID = 23,
                        ProductName = "Air Jordan 1 Low G (Mens)",
                        ProductPrice = 155.00M,
                        ProductDescription = "Feel unbeatable, from the tee box to the final putt. Inspired by one of the most iconic sneakers of all time, the Air Jordan 1 G is an instant classic on the course. With Air cushioning underfoot, a Wings logo on the heel and an integrated traction pattern to help you power through your swing, it delivers all the clubhouse cool of the original AJ1—plus everything you need to play 18 holes in comfort.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "White/Midnight Navy/Black",
                        ProductImageURL = "~/content/images/AirJordan_1_Low_G.jpg"
                    },
                    new Product
                    {
                        productID = 24,
                        ProductName = "Air Jordan 1 Mid Red (Mens)",
                        ProductPrice = 130.00M,
                        ProductDescription = "Inspired by the original AJ1, this mid-top edition maintains the iconic look you love while choice colors and crisp leather give it a distinct identity.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "White/Black/Gym Red",
                        ProductImageURL = "~/content/images/AirJordan_1_Mid_Red.jpg"
                    },
                    new Product
                    {
                        productID = 25,
                        ProductName = "Air Jordan 1 Mid White (Mens)",
                        ProductPrice = 131.00M,
                        ProductDescription = "Inspired by the original AJ1, the Air Jordan 1 Mid offers fans a chance to follow in MJ's footsteps. Fresh color trims the clean, classic materials, imbuing modernity into a classic design.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "White",
                        ProductImageURL = "~/content/images/AirJordan_1_Mid_White.jpg"
                    },
                    new Product
                    {
                        productID = 26,
                        ProductName = "Air Jordan 1 Zoom CMFT 2 (Mens)",
                        ProductPrice = 132.00M,
                        ProductDescription = "Premium suede and Jordan Brand's signature Formula 23 foam come together to give you an extra luxurious (and extra cozy) AJ1. You don't need to play \"either or\" when it comes to choosing style or comfort with this one—which is nice, 'cause you deserve both.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "Light Orewood Brown/Sail/Celestial Gold/Bright Citrus",
                        ProductImageURL = "~/content/images/AirJordan_1_Zoom_CMFT_2.jpg"
                    },
                    new Product
                    {
                        productID = 27,
                        ProductName = "Air Jordan 11 Gratitude (Mens)",
                        ProductPrice = 300.00M,
                        ProductDescription = "From us, to you—this release of the AJ11 is a \"Thank You\" to our day ones and those committed to carrying the Jordan legacy forward. Celebrating a heritage colorway, this classic honors MJ's legacy while elevating the materials for those pushing culture to new heights. The upper is designed with a mix of premium materials like luxe leather, along with a smooth knit collar. The glossy patent leather mudguard gleams just like the original. A tinted translucent outsole offers a clean finish while the welded gold Jumpman radiates the shoe's championship roots.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "White/Black",
                        ProductImageURL = "~/content/images/AirJordan_11_Gratitude.jpg"
                    },
                    new Product
                    {
                        productID = 28,
                        ProductName = "Air Jordan 13 Wheat (Mens)",
                        ProductPrice = 200.00M,
                        ProductDescription = "Celebrate 25 years of the AJ13 with a colorway bring-back. Dimpled full-grain White leather gets a soft, synthetic Wheat suede treatment for a boost of elegance. Capping it off, the green cat's eye emblem on the heel and panther paw-inspired outsole honor MJ's slick \"Black Cat\" alter ego.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "White/Wheat",
                        ProductImageURL = "~/content/images/AirJordan_13_Wheat.jpg"
                    },
                    new Product
                    {
                        productID = 29,
                        ProductName = "Air Jordan 4 Craft Olive (Mens)",
                        ProductPrice = 210.00M,
                        ProductDescription = "Here's the '89 classic, done up in elegant earth tones. Suede, leather and textiles come together in the upper for a truly textured look. And of course, all your favorite AJ4 elements are there too—like the floating eyestays and mesh-inspired side panels.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "Medium Olive/Cargo Khaki/Black/Pale Vanilla",
                        ProductImageURL = "~/content/images/AirJordan_4_Craft_Olive.jpg"
                    },
                    new Product
                    {
                        productID = 30,
                        ProductName = "Air Jordan 8 Winterized (Mens)",
                        ProductPrice = 210.00M,
                        ProductDescription = "Your cold-weather kicks have arrived. This AJ8 is designed with luxe leather, reflective elements and premium suede for durable style you can put to the test. Black and Gunsmoke pair with Metallic Silver for sleek seasonal style. It's an icy look that feels cool, whether it's winter or not.",
                        GenderID = 1,
                        BrandID = 1,
                        CategoryID = 1,
                        ProductColor = "Black/Metallic Silver/Gunsmoke",
                        ProductImageURL = "~/content/images/AirJordan_8_Winterized.jpg"
                    },
                    new Product
                    {
                        productID = 31,
                        ProductName = "Nike Jordan Brooklyn fleece crewneck sweatshirt (Womens)",
                        ProductPrice = 210.00M,
                        ProductDescription = "Cozy, but make it cool. This roomy, easy-fitting crew features mid-weight fleece for a soft feel. Combine that with elevated finishing touches and you have an everyday staple that truly stands out.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Velvet Brown",
                        ProductImageURL = "~/content/images/nike_jordan-brooklyn-fleece-womens-crewneck-sweatshirt-zvZ5ms.jpg"
                    },
                    new Product
                    {
                        productID = 32,
                        ProductName = "Jordan flight fleece crewneck sweatshirt (Womens)",
                        ProductPrice = 88.00M,
                        ProductDescription = "Meet your new favorite sweatshirt. The one you pull out of the dirty clothes pile because it’s too good not to wear one more time. (No one’s gonna know.) Super soft with a slightly oversized fit and extra volume in the sleeves, it's easy to pull on and perfect for layering.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Red Stardust",
                        ProductImageURL = "~/content/images/nike_jordan-flight-fleece-womens-crewneck-sweatshirt-rtRM9K.jpg"
                    },
                    new Product
                    {
                        productID = 33,
                        ProductName = "Jordan flight fleece winterized hoodie (Womens)",
                        ProductPrice = 108.00M,
                        ProductDescription = "Get cozy in a classic hoodie. Featuring a slightly fuzzy, heavyweight fleece in a roomy fit, you'll brave the cold in style. Satin lining on the hood means you can add coverage without worrying about your hair.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Black Heather",
                        ProductImageURL = "~/content/images/nike_jordan-flight-fleece-womens-winterized-hoodie-CGbKGT.jpg"
                    },
                    new Product
                    {
                        productID = 34,
                        ProductName = "Nike Sportswear Phoenix fleece (Womens)",
                        ProductPrice = 110.00M,
                        ProductDescription = "Rise up and transform your wardrobe with strong cozy vibes. You're sure to fall in love with the soft feel of brushed fleece, while the roomy design of this cardigan makes you feel—and look—stylishly carefree.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Rugged Orange/Black",
                        ProductImageURL = "~/content/images/nike_Sportswear_Phoenix_fleece.jpg"
                    },
                    new Product
                    {
                        productID = 35,
                        ProductName = "Nike Sportswear Club Fleece Crewneck Sweatshirt (Womens)",
                        ProductPrice = 40.00M,
                        ProductDescription = "Club Fleece sweatshirts, universally loved for their coziness and consistency, are for everyone. Always soft and made with a relaxed fit, they’re basics that help you do more. An essential for cold-weather layering, this crew-neck option is a quick and easy way to add warmth to your favorite puffer or jacket.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Diffused Blue/White",
                        ProductImageURL = "~/content/images/nike_sportswear-club-fleece-womens-crew-neck-sweatshirt-plus-size-DtqkgP.jpg"
                    },
                    new Product
                    {
                        productID = 36,
                        ProductName = "Nike Sportswear Club Fleece (Womens)",
                        ProductPrice = 80.00M,
                        ProductDescription = "Club Fleece sweatshirts, universally loved for their coziness and consistency, are for everyone. Always soft and made with a relaxed fit, they’re basics that help you do more. An essential for cold weather, this cozy pullover has just enough room to layer comfortably without feeling too big.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Fireberry/White",
                        ProductImageURL = "~/content/images/nike_sportswear-club-fleece-womens-logo-pullover-hoodie-07xm3D.jpg"
                    },
                    new Product
                    {
                        productID = 37,
                        ProductName = "Nike Sportswear Essential (Womens)",
                        ProductPrice = 81.00M,
                        ProductDescription = "This easy-fitting hoodie pairs soft fleece with tape-lined sleeves for a fresh-off-the-track finish. Smooth on the outside, slightly fuzzy on the inside, our midweight semi-brushed fleece helps keep you cozy while still being breezy. It’s a comfy layer to wear year-round, perfect for those tricky in-between temps.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Ale Brown/Cacao Wow",
                        ProductImageURL = "~/content/images/nike_sportswear-essential-womens-fleece-hoodie-4803DS.jpg"
                    },

                    new Product
                    {
                        productID = 38,
                        ProductName = "Nike Sportswear Phoenix Fleece (Womens)",
                        ProductPrice = 81.00M,
                        ProductDescription = "Grounded in style, comfort and versatility, meet our take on luxury loungewear. Our roomiest fit paired with exaggerated details (like the oversized pocket and taller ribbing) ensures this sweatshirt is anything but basic. All that's left to decide is whether to style it with the matching shorts or other pieces from your wardrobe.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Midnight Navy/Black",
                        ProductImageURL = "~/content/images/nike_sportswear-phoenix-fleece-womens-over-oversized-crew-neck-sweatshirt-nTshQw.jpg"
                    },
                    new Product
                    {
                        productID = 39,
                        ProductName = "Nike Sportswear Phoenix Fleece (Womens)",
                        ProductPrice = 90.00M,
                        ProductDescription = "Rise up and transform your fleece wardrobe with strong cozy vibes. Our midweight brushed fleece feels extra soft on the inside and smooth on the outside, helping you stay comfortable while keeping its structured shape. With a washed aesthetic and exaggerated details, this crew-neck sweatshirt gives you a broken-in look that's anything but basic.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Anthracite",
                        ProductImageURL = "~/content/images/nike_sportswear-phoenix-fleece-womens-oversized-crew-neck-sweatshirt-wbNcml.jpg"
                    },
                    new Product
                    {
                        productID = 40,
                        ProductName = "Nike Sportswear Phoenix Fleece (Womens)",
                        ProductPrice = 75.00M,
                        ProductDescription = "Grounded in style, comfort and versatility, meet our take on luxury loungewear. This classic hoodie helps you stay cozy all day long, thanks to midweight fleece that feels soft yet structured. Plus, exaggerated details (like taller ribbing and oversized fit) give you a trend-right look.",
                        GenderID = 2,
                        BrandID = 1,
                        CategoryID = 2,
                        ProductColor = "Midnight Navy/Black",
                        ProductImageURL = "~/content/images/nike_sportswear-phoenix-fleece-womens-oversized-pullover-hoodie-QnWVHw.jpg"
                    },
                    new Product
                    {
                        productID = 41,
                        ProductName = "ALL TERRAIN SUMMIT SANDAL (Mens)",
                        ProductPrice = 29.00M,
                        ProductDescription = "Travel. Exploration. Adventures near and far. The look and feel of our Classic All-Terrain Clog, now in sandal form. With a more rugged outsole, two upper straps and an adjustable turbo strap, the ground beneath your feet has never felt more surmountable. Seven holes on each sandal allow for personalization with Jibbitz™ charms and a lightweight Croslite™ construction makes them a practical and packable choice for any outing. It's time to shift into all-wheel drive. Flip that strap back and go find your fun!",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Espresso",
                        ProductImageURL = "~/content/images/p_crocs_mens_ALL_TERRAIN_SUMMIT_SANDAL.jpeg"
                    },
                    new Product
                    {
                        productID = 42,
                        ProductName = "CLASSIC CROCS MARBLED SANDAL (Mens)",
                        ProductPrice = 31.00M,
                        ProductDescription = "The comfortable Classic Crocs Sandal now sports our new marbled Croslite™ material that creates a fun, colorful effect. While all marbled sandals have the same wavy look, no two are exactly alike. Enjoy iconic Crocs comfort and stylish design in this unique casual sandal that’s perfect for everyday wear.",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Bone / Multi",
                        ProductImageURL = "~/content/images/p_crocs_mens_CLASSIC_CROCS_MARBLED_SANDAL.jpeg"
                    },
                    new Product
                    {
                        productID = 43,
                        ProductName = "Crocs Classic Slides (Mens)",
                        ProductPrice = 31.00M,
                        ProductDescription = "Original. Customizable. Comfortable. The ever-comfortable Classic II Slide gets the customization upgrade fans have been asking for in the Classic Crocs Slide: holes for Jibbitz™ charms! Each slide has room for 13 charms so you can load up your sandals with tons of personality. Original Croslite™ foam cushion will keep you comfortably supported from the beach to backyard gatherings and beyond. Choose your color and slide into a new favorite!",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Bone",
                        ProductImageURL = "~/content/images/P_crocs_mens_classic_slide.jpeg"
                    },
                    new Product
                    {
                        productID = 44,
                        ProductName = "Crocband Flip (Mens)",
                        ProductPrice = 31.00M,
                        ProductDescription = "All Flip, No Flop! Sporty and lightweight with the signature athletic stripe, the Crocband™ Flip is a colorful and incredibly comfortable warm-weather choice that pairs perfectly with shorts, slacks or swimwear. Constructed of easy-to-clean Croslite™ material, it’s ready for the beach, garden or anywhere else you choose to get your summer on!",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Bone",
                        ProductImageURL = "~/content/images/p_crocs_mens_crocband_flip.jpeg"
                    },
                    new Product
                    {
                        productID = 45,
                        ProductName = "CLASSIC CROCS MARBLED SLIDE (Mens)",
                        ProductPrice = 31.00M,
                        ProductDescription = "Enjoy the ever-comfortable Classic Crocs Slide now available in with a marbled effect. While all shoes have the same wavy look, no two are exactly alike, so you’ll have a completely unique pair. This special slide also features the Croslite™ footbed you love for an enjoyable ride. Choose your color and slide into a new favorite!",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Flame / White",
                        ProductImageURL = "~/content/images/p_mens_crocs_CLASSIC_CROCS_MARBLED_SLIDE.jpeg"
                    },
                    new Product
                    {
                        productID = 46,
                        ProductName = "Puma RS-Sandal (Mens)",
                        ProductPrice = 54.00M,
                        ProductDescription = "Streetwear, meet beachwear. The RS-Sandal takes the signature RS style for a ride with future-forward.",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Puma Black-High Rise",
                        ProductImageURL = "~/content/images/puma_mens_black_RS-Sandal.jpeg"
                    },
                    new Product
                    {
                        productID = 47,
                        ProductName = "Shibui Cat Slides (Mens)",
                        ProductPrice = 24.99M,
                        ProductDescription = "Slip into extreme comfort and set the trend with the new Shibui Cat Sandals from PUMA. These cozy kicks come with a fully injected IMEVA slide for a perfectly snug feel at home or wherever your feet may carry you. Minimalist PUMA Cat Logo branding adds a smooth finish.",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Black",
                        ProductImageURL = "~/content/images/puma_mens_Shibui-Cat-Slides.jpeg"
                    },
                    new Product
                    {
                        productID = 48,
                        ProductName = "RS-Sandal (Mens)",
                        ProductPrice = 54.99M,
                        ProductDescription = "Streetwear, meet beachwear. The RS-Sandal takes the signature RS style for a ride with future-forward detailing and ultra-cushioned RS tech.",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Marshmallow-Puma Black",
                        ProductImageURL = "~/content/images/puma_mens_RS-Sandal.jpeg"
                    },
                    new Product
                    {
                        productID = 49,
                        ProductName = "Softride Slides (Mens)",
                        ProductPrice = 39.99M,
                        ProductDescription = "Prioritize comfort without sacrificing style in these on-trend Softride slides. Whether you’re cooling down after a workout or rocking a casual summertime look, this footwear is designed to provide the best underfoot cushioning. The Softride footbed ensures every step you take feels sumptuous, while the durable synthetic strap is adjustable, guaranteeing the snuggest fit.",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "Puma Black-Puma White",
                        ProductImageURL = "~/content/images/puma_mens_Softride-Slides.jpeg"
                    },
                    new Product
                    {
                        productID = 50,
                        ProductName = "Softride Slides",
                        ProductPrice = 39.99M,
                        ProductDescription = "Prioritize comfort without sacrificing style in these on-trend Softride slides. Whether you’re cooling down after a workout or rocking a casual summertime look, this footwear is designed to provide the best underfoot cushioning. The Softride footbed ensures every step you take feels sumptuous, while the durable synthetic strap is adjustable, guaranteeing the snuggest fit.",
                        GenderID = 1,
                        BrandID = 4,
                        CategoryID = 3,
                        ProductColor = "White",
                        ProductImageURL = "~/content/images/puma_mens_white_Softride-Slides.jpeg"
                    }



                );
        }
    }
}
