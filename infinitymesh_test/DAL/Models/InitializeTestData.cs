using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;


namespace infinitymesh_test.DAL.Models
{
    public class InitializeTestData
    {

        private TempDB _context;

        public InitializeTestData(TempDB context)
        {
            _context = context;

        }


        public async Task SeedDB()
        {
            if (!_context.Users.Any())
            {
                _context.AddRange(Users);
               await _context.SaveChangesAsync();
            }

            if (!_context.Blogs.Any())
            {
                _context.AddRange(Blogs);
                await _context.SaveChangesAsync();
            }
        }


        public List<Users> Users = new List<Users>
        {
              #region generate users
            new Users()
                {
                    Name ="Tom Tom",
                    Age = 18,
                    Email = "someemail",
                    Username = "NameUsegdfsr",
                    Password = "doesntmatt321er"
                },
                new Users()
                {
                    Name = "John Smith",
                    Age = 31,
                    Email = "johnsmith@domain.com",
                    Username = "john123",
                    Password = "password123"
                },
                new Users()
                {
                    Name = "Tim Johnson",
                    Age = 19,
                    Email = "tim@domain.com",
                    Username = "tim567",
                    Password = "12345"
                },
                 new Users()
                {
                    Name = "Marianna McGavin",
                    Age = 22,
                    Email = "marianna@domain.com",
                    Username = "marianna",
                    Password = "12345"
                },
                  new Users()
                {
                    Name = "Maria Stones",
                    Age = 22,
                    Email = "maria@domain.com",
                    Username = "marias",
                    Password = "12345"
                },
                   new Users()
                {
                    Name = "Nina Tan",
                    Age = 26,
                    Email = "nina@domain.com",
                    Username = "ninat",
                    Password = "doesntfdamatter"
                },
                  new Users()
                {
                    Name = "Camille Dyson",
                    Age = 23,
                    Email = "camille@domain.com",
                    Username = "dysonc",
                    Password = "doesntfdamatter"
                },
                new Users()
                {
                    Name = "Alana Ting",
                    Age = 35,
                    Email = "alana@domain.com",
                    Username = "alana",
                    Password = "doesntfdamatter"
                },
                 new Users()
                {
                    Name = "Alan Baker",
                    Age = 37,
                    Email = "alan@domain.com",
                    Username = "alan",
                    Password = "doesntfdamatter"
                },
                new Users()
                {
                    Name = "Layla Cobb",
                    Age = 30,
                    Email = "layla@domain.com",
                    Username = "layla",
                    Password = "doesntfdamatter"
                },
               new Users()
                {
                    Name = "Alvena Parsons",
                    Age = 23,
                    Email = "alvena@domain.com",
                    Username = "alvena",
                    Password = "doesntfdamatter"
                },
                new Users()
                {
                  Name = "Ellis Scrivenor",
                    Age = 28,
                    Email = "ellis@domain.com",
                    Username = "ellis",
                    Password = "doesntfdamatter"
                },

                new Users()
                {
                  Name = "Ava Turnbull",
                    Age = 25,
                    Email = "ava@domain.com",
                    Username = "ava",
                    Password = "doesntfdamatter"
                 },

                new Users()
                {
                  Name = "Madelyn Tuning",
                    Age = 28,
                    Email = "madelyn@domain.com",
                    Username = "madelyn123",
                    Password = "doesntfdamatter"
                 },

                new Users()
                {
                  Name = "Kelley Layton",
                    Age = 28,
                    Email = "kelley@domain.com",
                    Username = "kelley999",
                    Password = "doesntfdamatter"
                },

                new Users()
                {
                  Name = "Clair Marlowe",
                    Age = 29,
                    Email = "Clair@domain.com",
                    Username = "Clair",
                    Password = "doesntfdamatter"
                  },
                new Users()
                {
                  Name = "Eli Parker",
                    Age = 20,
                    Email = "eli@domain.com",
                    Username = "eli",
                    Password = "doesntfdamatter"
                }
                #endregion
        };

        public List<Blogs> Blogs = new List<Blogs>
        {
            #region generate blogs
            new Blogs()
            {
                Title = "Title1",
                Summary = "Summary123",
                Content = "Content1234",
                PublishedDateTime = new DateTime(2018, 1, 12, 18, 15, 33),
                UserID = 1
             },
                 new Blogs()
            {
                Title = "Blog Title 1",
                Summary = "Lorem Ipsum is simply",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                PublishedDateTime = new DateTime(2017, 3, 14, 15, 15, 33),
                 UserID = 2
             },
             new Blogs()
            {
                Title = "Blog Title 1",
                Summary = "Lorem Ipsum is simply",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                PublishedDateTime = new DateTime(2017, 3, 14, 15, 15, 33),
                 UserID = 1
             },

             new Blogs()
            {
                Title = "Blog Title 2",
                Summary = "Why do we use it?",
                Content =  "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ",
                PublishedDateTime = new DateTime(2017, 4, 22, 11, 10, 33),
              UserID = 3
             },
            new Blogs()
            {
                Title = "Some Title 1",
                Summary = "Where does it come from?",
                Content =  "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words",
                PublishedDateTime = new DateTime(2018, 1, 12, 18, 15, 33),
               UserID = 3
            },
            new Blogs()
            {
                Title = "Red Destiny",
                Summary = "Destiny",
                Content =  "Same an quit most an. Admitting an mr disposing sportsmen. Tried on cause no spoil arise plate. Longer ladies valley get esteem use led six. Middletons resolution advantages expression themselves partiality so me at. West none hope if sing oh sent tell is. ",
                PublishedDateTime = new DateTime(2017, 5, 2, 1, 15, 33),
                UserID = 4
            },
            new Blogs()
            {
                Title = "The Invisible Sorcerer",
                Summary = "Sorcerer",
                Content =   "Wise busy past both park when an ye no. Nay likely her length sooner thrown",
                PublishedDateTime = new DateTime(2017, 6, 14, 18, 15, 33),
               UserID = 5
            },
            new Blogs()
            {
                Title = "Death of Beginning",
                Summary = "Beginning",
                Content =  "Ever man are put down his very. And marry may table him avoid.",
                PublishedDateTime = new DateTime(2017, 7, 26, 18, 15, 33),
                UserID = 5
            },
            new Blogs()
            {
                Title = "The Night Elves",
                Summary = "Elves",
                Content =   "Needed feebly dining oh talked wisdom oppose at. Applauded use attempted",
                PublishedDateTime = new DateTime(2016, 5, 22, 18, 15, 33),
                UserID = 6
             },
            new Blogs()
            {
                Title = "The Time of the Secret",
                Summary = "Secret",
                Content =  "In post mean shot ye. There out her child sir his lived. Design at uneasy me season of branch on praise esteem. Abilities discourse believing consisted remaining to no. Mistaken no me denoting dashwood as screened. Whence or esteem easily he on. Dissuade husbands at of no if disposal. ",
                PublishedDateTime = new DateTime(2017, 1, 2, 18, 15, 33),
              UserID = 6
            },
            new Blogs()
            {
                Title = "Heart in the Prince",
                Summary = "Prince",
                Content =  "Both rest of know draw fond post as. It agreement defective to excellent.",
                PublishedDateTime = new DateTime(2017, 2, 12, 18, 15, 33),
                UserID = 7
            },
            new Blogs()
            {
                Title = "What Tales",
                Summary = "Tales",
                Content =  "Style never met and those among great.",
                PublishedDateTime = new DateTime(2018, 1, 12, 18, 15, 33),
                UserID = 7
            },
                new Blogs()
            {
                Title = "The Vacant Shadow",
                Summary =  "Shadow",
                Content =  "On recommend tolerably my belonging or am. Mutual has cannot beauty indeed now",
                PublishedDateTime = new DateTime(2018, 5, 4, 18, 15, 33),
                UserID = 7
            },
                new Blogs()
            {
                Title = "Kiss of Servants",
                Summary = "Kiss of Servants",
                Content =  "Cultivated who resolution connection motionless did occasional.",
                PublishedDateTime = new DateTime(2018, 1, 19, 18, 15, 33),
                UserID = 8
            },
                new Blogs()
            {
                Title = "The Snow's Male",
                Summary = "The Snow's Male",
                Content =  "Is we miles ready he might going. Own books built put civil fully blind",
                PublishedDateTime = new DateTime(2018, 2, 13, 18, 15, 33),
                UserID = 8
             },
             new Blogs()
            {
                Title = "The School of Thorn",
                Summary = "The School of Thorn",
                Content =  "Detract yet delight written farther his general.",
                PublishedDateTime = new DateTime(2017, 11, 12, 18, 15, 33),
                UserID = 10
             }
             #endregion
        };



    //public TempDB PrepareData(TempDB model)
    //    {


    //        var service = new BlogService(model);
    //        #region generate users
    //        service.AddUser("Tom Tom", 18, "someemail", "NameUsegdfsr", "doesntmatt321er");
    //        service.AddUser(new Users() { Name = "John Smith", Age = 31, Email = "johnsmith@domain.com", Username = "john123", Password = "password123" });
    //        Users a;
    //        a = new Users("Tim Johnson", 19, "tim@domain.com", "tim567", "12345");
    //        service.AddUser(a);
    //        a = new Users("Maria Stones", 22, "maria@domain.com", "marias", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Nina Tan", 26, "nina@domain.com", "ninat", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Camille Dyson", 23, "camille@domain.com", "dysonc", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Alana Ting", 35, "alana@domain.com", "alana@domain.com", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Layla Cobb", 30, "layla@domain.com", "layla@domain.com", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Alvena Parsons", 23, "Parsons", "alvena@domain.com", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Ellis Scrivenor", 28, "ellis@domain.com", "ellis@domain.com", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Ava Turnbull", 25, "ava@domain.com", "ava@domain.com", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Madelyn Tuning", 31, "madelyn@domain.com", "madelyn123", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Kelley Layton", 30, "kelley@domain.com", "kelley999", "doesntfdamatter");
    //        service.AddUser(a);
    //        a = new Users("Clair Marlowe", 29, "clair@domain.com", "clairemarlow", "doesntfdamatter");
    //        service.AddUser(a);
    //        #endregion

    //        #region generate blogs

    //        DateTime q = new DateTime(2018, 1, 12, 18, 15, 33);
    //        Blogs M = new Blogs("Title1", "Summary123", "Content1234", q, 1);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 3, 14, 15, 15, 33);
    //        M = new Blogs("Blog Title 1", "Lorem Ipsum is simply", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", q, 1);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 4, 22, 11, 10, 33);
    //        M = new Blogs("Blog Title 2", "Why do we use it?", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", q, 1);
    //        service.AddBlogs(M);
    //        q = new DateTime(2018, 1, 12, 18, 15, 33);
    //        M = new Blogs("Some Title", "Where does it come from?", "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, ", q, 1);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 5, 2, 1, 15, 33);
    //        M = new Blogs("Red Destiny", "Destiny", "Same an quit most an. Admitting an mr disposing sportsmen. Tried on cause no spoil arise plate. Longer ladies valley get esteem use led six. Middletons resolution advantages expression themselves partiality so me at. West none hope if sing oh sent tell is. ", q, 1);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 6, 14, 18, 15, 33);
    //        M = new Blogs("The Invisible Sorcerer", "Sorcerer", "Wise busy past both park when an ye no. Nay likely her length sooner thrown sex lively income. The expense windows adapted sir. Wrong widen drawn ample eat off doors money. Offending belonging promotion provision an be oh consulted ourselves it. Blessing welcomed ladyship she met humoured sir breeding her. Six curiosity day assurance bed necessary.", q, 2);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 7, 26, 18, 15, 33);
    //        M = new Blogs("Death of Beginning", "Beginning", "Ever man are put down his very. And marry may table him avoid. Hard sell it were into it upon. He forbade affixed parties of assured to me windows. Happiness him nor she disposing provision. Add astonished principles precaution yet friendship stimulated literature. State thing might stand one his plate. Offending or extremity therefore so difficult he on provision. Tended depart turned not are. ", q, 2);
    //        service.AddBlogs(M);
    //        q = new DateTime(2016, 5, 22, 18, 15, 33);
    //        M = new Blogs("The Night Elves", "Elves", "Needed feebly dining oh talked wisdom oppose at. Applauded use attempted strangers now are middleton concluded had. It is tried ﻿no Added purse shall no on truth. Pleased anxious or as in by viewing forbade minutes prevent. Too leave had those get being led weeks blind. Had men rose from down lady able. Its son him ferrars proceed six parlors. Her say projection age announcing decisively men. Few gay sir those green men timed downs widow chief. Prevailed remainder may propriety can and. ", q, 3);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 1, 2, 18, 15, 33);
    //        M = new Blogs("The Time of the Secret", "Secret", "In post mean shot ye. There out her child sir his lived. Design at uneasy me season of branch on praise esteem. Abilities discourse believing consisted remaining to no. Mistaken no me denoting dashwood as screened. Whence or esteem easily he on. Dissuade husbands at of no if disposal. ", q, 3);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 2, 12, 18, 15, 33);
    //        M = new Blogs("Heart in the Prince", "Prince", "Both rest of know draw fond post as. It agreement defective to excellent. Feebly do engage of narrow. Extensive repulsive belonging depending if promotion be zealously as. Preference inquietude ask now are dispatched led appearance. Small meant in so doubt hopes. Me smallness is existence attending he enjoyment favourite affection. Delivered is to ye belonging enjoyment preferred. Astonished and acceptance men two discretion. Law education recommend did objection how old. ", q, 3);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 8, 12, 18, 15, 33);
    //        M = new Blogs("What Tales", "Tales", "Style never met and those among great. At no or september sportsmen he perfectly happiness attending. Depending listening delivered off new she procuring satisfied sex existence. Person plenty answer to exeter it if. Law use assistance especially resolution cultivated did out sentiments unsatiable. Way necessary had intention happiness but september delighted his curiosity. Furniture furnished or on strangers neglected remainder engrossed. ", q, 3);
    //        service.AddBlogs(M);
    //        q = new DateTime(2018, 5, 4, 18, 15, 33);
    //        M = new Blogs("The Vacant Shadow", "Shadow", "On recommend tolerably my belonging or am. Mutual has cannot beauty indeed now sussex merely you. It possible no husbands jennings ye offended packages pleasant he. Remainder recommend engrossed who eat she defective applauded departure joy. Get dissimilar not introduced day her apartments. Fully as taste he mr do smile abode every. Luckily offered article led lasting country minutes nor old. Happen people things oh is oppose up parish effect. Law handsome old outweigh humoured far appetite. ", q, 4);
    //        service.AddBlogs(M);
    //        q = new DateTime(2018, 1, 19, 18, 15, 33);
    //        M = new Blogs("Kiss of Servants", "Servants", "Cultivated who resolution connection motionless did occasional. Journey promise if it colonel. Can all mirth abode nor hills Added. Them men does for body pure. Far end not horses remain sister. Mr parish is to he answer roused piqued afford sussex. It abode words began enjoy years no do ﻿no. Tried spoil as heart visit blush or. Boy possible blessing sensible set but margaret interest. Off tears are day blind smile alone had. ", q, 5);
    //        service.AddBlogs(M);
    //        q = new DateTime(2018, 2, 13, 18, 15, 33);
    //        M = new Blogs("The Snow's Male", "Snow's Male", "Is we miles ready he might going. Own books built put civil fully blind fanny. Projection appearance at of admiration no. As he totally cousins warrant besides ashamed do. Therefore by applauded acuteness supported affection it. Except had sex limits county enough the figure former Add. Do sang my he next mr soon. It merely waited do unable. ", q, 5);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 11, 12, 18, 15, 33);
    //        M = new Blogs("The School of Thorn", "Thorn", "Detract yet delight written farther his general. If in so bred at dare rose lose good. Feel and make two real miss use easy. Celebrated delightful an especially increasing instrument am. Indulgence contrasted sufficient to unpleasant in in insensible favourable. Latter remark hunted enough vulgar say man. Sitting hearted on it without me. ", q, 5);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 9, 18, 18, 15, 33);
    //        M = new Blogs("Son in the Man", "Son in the man", "Of on affixed civilly moments promise explain fertile in. Assurance advantage belonging happiness departure so of. Now improving and one sincerity intention allowance commanded not. Oh an am frankness be necessary earnestly advantage estimable extensive. Five he wife gone ye. Mrs suffering sportsmen earnestly any. In am do giving to afford parish settle easily garret. ", q, 5);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 2, 12, 18, 15, 33);
    //        M = new Blogs("Final Witches", "Witches", "Fat son how smiling mrs natural expense anxious friends. Boy scale enjoy ask abode fanny being son. As material in learning subjects so improved feelings. Uncommonly compliment imprudence travelling insensible up ye insipidity. To up painted delight winding as brandon. Gay regret eat looked warmth easily far should now. Prospect at me wandered on extended wondered thoughts appetite to. Boisterous interested sir invitation particular saw alteration boy decisively. ", q, 6);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 8, 23, 18, 15, 33);
    //        M = new Blogs("The Bound Husband", "Husband", "Gave read use way make spot how nor. In daughter goodness an likewise oh consider at procured wandered. Songs words wrong by me hills heard timed. Happy eat may doors songs. Be ignorant so of suitable dissuade weddings together. Least whole timed we is. An smallness deficient discourse do newspaper be an eagerness continued. Mr my ready guest ye after short at. ", q, 7);
    //        service.AddBlogs(M);
    //        q = new DateTime(2016, 12, 18, 18, 15, 33);
    //        M = new Blogs("Snake of Crying", "Crying", "Smile spoke total few great had never their too. Amongst moments do in arrived at my replied. Fat weddings servants but man believed prospect. Companions understood is as especially pianoforte connection introduced. Nay newspaper can sportsman are admitting gentleman belonging his. Is oppose no he summer lovers twenty in. Not his difficulty boisterous surrounded bed. Seems folly if in given scale. Sex contented dependent conveying advantage can use. ", q, 8);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 11, 2, 18, 15, 33);
    //        M = new Blogs("The Angel's flames", "flames", "From they fine john he give of rich he. They age and draw mrs like. Improving end distrusts may instantly was household applauded incommode. Why kept very ever home mrs. Considered sympathize ten uncommonly occasional assistance sufficient not. Letter of on become he tended active enable to. Vicinity relation sensible sociable surprise screened no up as. ", q, 9);
    //        service.AddBlogs(M);
    //        q = new DateTime(2017, 10, 13, 18, 15, 33);
    //        M = new Blogs("The Weeping of the Thief", "Thief", "On it differed repeated wandered required in. Then girl neat why yet knew rose spot. Moreover property we he kindness greatest be oh striking laughter. In me he at collecting affronting principles apartments. Has visitor law attacks pretend you calling own excited painted. Contented attending smallness it oh ye unwilling. Turned favour man two but lovers. Suffer should if waited common person little oh. Improved civility graceful sex few smallest screened settling. Likely active her warmly has. ", q, 10);
    //        service.AddBlogs(M);

    //        #endregion

    //        return model;
    //    }



}
}