using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Models.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                    new Category
                    { CategoryId = 1 ,
                                   Description = "Philosophy is the exploration of fundamental questions about the nature of reality,knowledge, ethics, and the meaning of life." +
                                   " Philosophers engage in deep contemplation and critical thinking to seek answers to profound and timeless questions." +
                                   "Philosophy books often present diverse perspectives and arguments on these fundamental issues." 
                                   , Name ="Philosophy" ,
                                   LogoImage = "cat1.png"
                    },

                    new Category
                    {   CategoryId = 2,
                        Description = "Science is a genre that explores the natural world through empirical observation, experimentation, and the systematic study of phenomena." +
                        "Science books cover a wide range of topics, from physics and biology to"+
                        "astronomy and environmental science. They aim to explain the workings of the universe and our place in it based on evidence and the scientific method.",
                        Name = "Science",
                        LogoImage = "cat2.png"

                    },

                    new Category
                    {
                        CategoryId = 3,
                        Description = "  History books recount and analyze past events, civilizations, and human experiences." +
                        " They provide insights into the achievements, challenges, and cultures of different time periods and regions." +
                        " History books can cover a wide range of topics, from ancient civilizations to modern history, and help us understand how societies have evolved over time.",
                        Name = "History",
                        LogoImage = "cat3.png"
                    },

                    new Category
                    {
                        CategoryId= 4,
                        Description = " Biography books tell the life stories of real individuals, offering readers a glimpse into the lives, achievements, and struggles of notable figures. " +
                        "These books provide personal insights into the experiences and contributions of historical figures," +
                        "artists, leaders, and everyday people who have made a significant impact on the world.",
                        Name ="Biography",
                        LogoImage = "cat4.png"
                    },

                    new Category
                    {
                        CategoryId = 5,
                        Description = "  Adventure literature takes readers on exciting journeys filled with risks, challenges, and thrilling experiences." +
                        "These books often feature protagonists embarking on daring quests, exploring uncharted territories, and encountering various obstacles and adventures." +
                        "Adventure stories can be set in historical, contemporary, or fantastical settings.",
                        Name = "Adventure",
                        LogoImage = "cat5.png"
                    },

                    new Category
                    {
                        CategoryId = 6,
                        Description = "Fantasy literature transports readers to imaginative and magical worlds where the rules of reality are bent or entirely rewritten." +
                        "These books feature mythical creatures, enchanted lands, and epic quests." +
                        "Fantasy authors create richly detailed and otherworldly settings, allowing readers to escape into realms of wonder, magic, and adventure.",
                        Name = "Fantasy",
                        LogoImage = "cat6.png"
                    }
                );
        }
    }
}
