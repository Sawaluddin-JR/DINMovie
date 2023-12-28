using DINMovie.Data.Enums;
using DINMovie.Models;

namespace DINMovie.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "/images/cinemas/cinema-1.jpg",
                            Description = "This is  the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "/images/cinemas/cinema-2.jpg",
                            Description = "This is  the description of the second cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "/images/cinemas/cinema-3.jpg",
                            Description = "This is  the description of the third cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "/images/cinemas/cinema-4.jpg",
                            Description = "This is  the description of the fourth cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "/images/cinemas/cinema-5.jpg",
                            Description = "This is  the description of the fiveth cinema"
                        }
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Iko Uwais",
                            Bio = "This is the Bio of the first actor",
                            ProfilPictureURL = "https://cdn-1.timesmedia.co.id/images/2023/09/20/iko.uwais.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Reza Rahardian",
                            Bio = "This is the Bio of the second actor",
                            ProfilPictureURL = "https://media.suara.com/pictures/653x366/2021/12/10/25238-reza-rahadian.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Iqbal Ramadhan",
                            Bio = "This is the Bio of the third actor",
                            ProfilPictureURL = "https://cdn-2.tstatic.net/newsmaker/foto/bank/images/iqbal-ramadhan-pernah-ditolak-cewek.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Adipati Dolken",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilPictureURL = "https://asset-2.tstatic.net/tribunnewswiki/foto/bank/images/adipati-dolken.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Ciko Jeriko",
                            Bio = "This is the Bio of the fiveth actor",
                            ProfilPictureURL = "https://cdn.kincir.com/2/production/2021-05/aktor-indonesia-terkenal-sinetron-film-1~05fbb7b0-8cfb-42cf-8cbf-45c405ac7ae9.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producer.Any())
                {
                    context.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first producer",
                            ProfilPictureUrl = "/images/producers/producer-1.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second producer",
                            ProfilPictureUrl = "/images/producers/producer-2.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the thirdth producer",
                            ProfilPictureUrl = "/images/producers/producer-3.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the fourth producer",
                            ProfilPictureUrl = "/images/producers/producer-4.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the fiveth producer",
                            ProfilPictureUrl = "/images/producers/producer-5.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.AddRange(new List<Movie>()
                    {
                       new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.ActorMovies.Any())
                {
                    context.AddRange(new List<ActorMovie>()
                    {
                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
