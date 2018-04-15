using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StoreFront.Models
{
    public static class Seeds
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new StoreContext(
                serviceProvider.GetRequiredService<DbContextOptions<StoreContext>>()))
            {
                if (!context.Category.Any())
                {
                    context.Category.AddRange(
                        new Category
                        {
                            Name = "Deck Building",
                            Image = "Categories/deck.jpg",
                            ID = 1
                        },
                        new Category
                        {
                            Name = "Strategy",
                            Image = "Categories/strategy.jpg",
                            ID = 2
                        },
                        new Category
                        {
                            Name = "Fantasy",
                            Image = "Categories/fantasy.jpg",
                            ID = 3
                        }
                    );
                    context.SaveChanges();
                }
                if (!context.Product.Any())
                {
                    context.Product.AddRange(
                        new Product 
                        { 
                            Name = "Gloomhaven", 
                            ID = 1, 
                            Price = 189.99M,
                            NumberOfPlayers = "1-4", 
                            PlayTime = "30-120 Min", 
                            CategoryId = 3, 
                            DefaultImage = "Gloomhaven/cover.jpg",
                            Rating = 4,
                            Description = "Gloomhaven is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world. Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process, they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make."
                                
                        },
                        new Product { 
                        Name = "7 Wonders", 
                            ID = 2, 
                            Price = 39.99M,
                            NumberOfPlayers = "2-7", 
                            PlayTime = "30 Min", 
                            CategoryId = 1, 
                            DefaultImage = "7Wonders/cover.jpg",
                            Rating = 5,
                        Description = "You are the leader of one of the 7 great cities of the Ancient World. Gather resources, develop commercial routes, and affirm your military supremacy. Build your city and erect an architectural wonder which will transcend future times."
                                 
                        },
                        new Product 
                        {
                        Name = "Civilization", 
                            ID = 3, 
                            Price = 50.99M,
                            NumberOfPlayers = "2-4",
                            PlayTime = "120–240 Min",  
                            CategoryId = 2, 
                        DefaultImage = "Civilization/cover.jpg",
                            Rating = 4,
                        Description = "Before you lies a vast bounty of land, ripe for the plucking. Your meager beginnings will influence the paths you must take. Lead your people well and they will take you to infinite heights of greatness. If civilization manages to endure the ages, your name will hang in every whisper of its legacy..."
                                
                        },
                        new Product 
                        { 
                        Name = "Dominion", 
                            ID = 4, 
                            Price = 29.99M,
                        NumberOfPlayers = "2-4", 
                            PlayTime = "30 Min", 
                            CategoryId = 1, 
                            DefaultImage = "Dominion/cover.jpg",
                            Rating = 3,
                        Description = "You are a monarch, like your parents before you, a ruler of a small pleasant kingdom of rivers and evergreens. Unlike your parents, however, you have hopes and dreams! You want a bigger and more pleasant kingdom, with more rivers and a wider variety of trees. You want a Dominion! In all directions lie fiefs, freeholds, and feodums. All are small bits of land, controlled by petty lords and verging on anarchy. You will bring civilization to these people, uniting them under your banner."
                                
                        },
                        new Product 
                        { 
                        Name = "Splendor", 
                            ID = 5, 
                            Price = 24.99M,
                        NumberOfPlayers = "2-4", 
                            PlayTime = "30 Min", 
                            CategoryId = 3, 
                            DefaultImage = "Splendor/cover.jpg",
                            Rating = 2,
                            Description ="Splendor is a game of chip-collecting and card development. Players are merchants of the Renaissance trying to buy gem mines, means of transportation, shops—all in order to acquire the most prestige points. If you're wealthy enough, you might even receive a visit from a noble at some point, which of course will further increase your prestige."
                        },
                        new Product 
                        { 
                            Name = "Axis & Allies", 
                            ID = 6, 
                            Price = 39.99M,
                            NumberOfPlayers = "2-5",
                            PlayTime = "180 Min",  
                            CategoryId = 3, 
                            DefaultImage = "AxisAndAllies/cover.jpg",
                            Rating = 1,
                            Description = "Axis and Allies is the most successful of Milton Bradley's Gamemaster series. It depicts WWII on a grand scale, full global level.Up to five players can play on two different teams.The Axis which has Germany and Japan, and the Allies which has the USA, the United Kingdom, and the USSR.A full map of the world is provide broken up in various chunks similar to Risk.The game comes with gobs of plastic miniatures that represent various military units during WWII.Players have at their disposal infantry, armor, fighters, bombers, battleships, aircraft carriers, submarines, troop transports, anti - air guns, and factories. All of the units perform differently and many have special functions.Players have to work together with their teammates in order to coordinate offenses and decide how best to utilize their production points.Players also have the option of risking production resources on the possibility of developing a super technology that might turn the tide of war."
                    
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Image.Any())
                {
                    context.Image.AddRange(
                        new Image
                        {
                            Url = "Gloomhaven/cover.jpg",
                            Place = 1,
                            ProductId = 1
                        },
                        new Image
                        {
                        Url = "Gloomhaven/gameplay1.jpg",
                            Place = 2,
                            ProductId = 1
                        },
                        new Image
                        {
                        Url = "Gloomhaven/gameplay2.jpg",
                            Place = 3,
                            ProductId = 1
                        },
                        new Image
                        {
                        Url = "Gloomhaven/gameplay3.jpg",
                            Place = 4,
                            ProductId = 1
                    },
                        new Image
                        {
                            Url = "Gloomhaven/gameplay4.jpg",
                            Place = 5,
                            ProductId = 1
                        }
                    );
                    context.Image.AddRange(
                        new Image
                        {
                            Url = "7Wonders/cover.jpg",
                            Place = 1,
                            ProductId = 2
                        },
                        new Image
                        {
                            Url = "7Wonders/gameplay1.jpg",
                            Place = 2,
                            ProductId = 2
                        },
                        new Image
                        {
                        Url = "7Wonders/gameplay2.jpg",
                            Place = 3,
                            ProductId = 2
                        },
                        new Image
                        {
                        Url = "7Wonders/gameplay3.jpg",
                            Place = 4,
                            ProductId = 2
                        }
                    );
                    context.Image.AddRange(
                        new Image
                        {
                            Url = "Civilization/cover.jpg",
                            Place = 1,
                            ProductId = 3
                        },
                        new Image
                        {
                        Url = "Civilization/gameplay1.jpg",
                            Place = 2,
                            ProductId = 3
                        },
                        new Image
                        {
                        Url = "Civilization/gameplay2.jpg",
                            Place = 3,
                            ProductId = 3
                        },
                        new Image
                        {
                        Url = "Civilization/gameplay3.jpg",
                            Place = 4,
                            ProductId = 3
                        },
                        new Image
                        {
                        Url = "Civilization/gameplay4.jpg",
                            Place = 5,
                            ProductId = 3
                        }
                    );
                    context.Image.AddRange(
                        new Image
                        {
                            Url = "Dominion/cover.jpg",
                            Place = 1,
                            ProductId = 4
                        },
                        new Image
                        {
                        Url = "Dominion/gameplay1.jpg",
                            Place = 2,
                            ProductId = 4
                        },
                        new Image
                        {
                        Url = "Dominion/gameplay2.jpg",
                            Place = 3,
                            ProductId = 4
                        },
                        new Image
                        {
                        Url = "Dominion/gameplay3.jpg",
                            Place = 4,
                            ProductId = 4
                        }
                    );
                    context.Image.AddRange(
                        new Image
                        {
                            Url = "Splendor/cover.jpg",
                            Place = 1,
                            ProductId = 5
                        },
                        new Image
                        {
                        Url = "Splendor/gameplay1.jpg",
                            Place = 2,
                            ProductId = 5
                        },
                        new Image
                        {
                        Url = "Splendor/gameplay2.jpg",
                            Place = 3,
                            ProductId = 5
                        },
                        new Image
                        {
                        Url = "Splendor/gameplay3.jpg",
                            Place = 4,
                            ProductId = 5
                        }
                    );
                    context.Image.AddRange(
                        new Image
                        {
                            Url = "AxisAndAllies/cover.jpg",
                            Place = 1,
                            ProductId = 6
                        },
                        new Image
                        {
                        Url = "AxisAndAllies/gameplay1.jpg",
                            Place = 2,
                            ProductId = 6
                        },
                        new Image
                        {
                        Url = "AxisAndAllies/gameplay2.jpg",
                            Place = 3,
                            ProductId = 6
                        },
                        new Image
                        {
                        Url = "AxisAndAllies/gameplay3.jpg",
                            Place = 4,
                            ProductId = 6
                        }
                        ,
                        new Image
                        {
                            Url = "AxisAndAllies/gameplay4.jpg",
                            Place = 5,
                            ProductId = 6
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
