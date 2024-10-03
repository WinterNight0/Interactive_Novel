using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Adventure_Game
{
    class Program
    {
        /*
         note :
        Console.WriteLine("");
         */

        static void Main(string[] args)
        {
            gameTitle();
            Prologue();

        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to Interactive Novel Game");
            Console.WriteLine("This Project Made For Present Teacher Nikhom Thidkhaw");
            Console.WriteLine("Press 'Enter' To Start The Game");
            Console.ReadLine();
            Console.Clear();
            Prologue();
        }

        public static void Prologue()
        {
            Console.WriteLine("Welcome to 'mobius' the world of magic and wisdom where dreams come true");
            Console.WriteLine("In this world people were born with magical powers such as flame ice electrical water anything you could ever imagine.");
            Console.WriteLine("But these magical powers will reveal when you do a ritual by drawing a symbol of the element.");
            Console.WriteLine("The better power you have the more abilities you could choose.");
            Console.WriteLine("Each academy will have a different elemental mastery power.");
            Console.WriteLine("When they have graduated they would become mages and they have ranks for mages.");
            Console.WriteLine("Rookie,Novice,Expert,Master and Grand Master.");
            Console.WriteLine("You will receive the grand master rank once you mastered your element");
            Console.WriteLine("You are the normal student name 'Atia'");
            Console.ReadLine();
            Console.Clear();
            Con1();
        }

        public static void Con1()
        {
            string choice1;

            Console.WriteLine("-The day that every teenager have to take a ritual test-");
            Console.WriteLine();
            Console.WriteLine("Sundei - Hey,Do you think I’ll pass the ritual test");
            Console.ReadKey();
            Console.WriteLine("Atia - I’m not so sure,But do i really need to take the test");
            Console.ReadKey();
            Console.WriteLine("Sundei - You'll pass im sure of it");
            Console.ReadKey();
            Console.WriteLine("Atia - But I don’t think my power is strong enough");
            Console.ReadKey();
            Console.WriteLine("Sundei - Relax it's only just the ritual test");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Teacher - Mr.Atia. Please put your hand on the magic meter");
            Console.ReadKey();
            Console.WriteLine("Teacher - Next Mr.Sundei...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("On the date of the result announcement Atia look for his result.");
            Console.WriteLine("He find that he pass the test unfortunately his friend failed it");
            Console.WriteLine();
            Console.WriteLine("What will you do?");
            Console.WriteLine("1.)Comfort your friend");
            Console.WriteLine("2.)Tell the instructor that the result had an error");
            Console.WriteLine("*Type only '1' or '2'*");
            Console.Write("Choice: ");
            choice1 = Console.ReadLine().ToLower();

            switch (choice1)
            {
                case "1":
                    {
                        Console.WriteLine();
                        Console.WriteLine("It is fine don't take it serious,you are the best person i've ever met i know you can handle it");
                        Console.ReadLine();
                        Con2();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sundie took another test but ended up fail the test just the same as first time.\nBut sundie doesn't feel sad cause he tried his best");
                        Console.ReadLine();
                        Con2();
                        break;
                    }
                default:
                    {

                        Console.WriteLine();
                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        Console.Clear();
                        Con1();
                        break;

                    }

            }

        }



        public static void Con2()
        {

            string choice2;

            Console.WriteLine("- 2 years later -");
            Console.WriteLine();
            Console.WriteLine("*Atia walking aloan in academy*");
            Console.WriteLine("Atia - ~sigh~ When will this end I don't want to get prank by them anymore");
            Console.ReadKey();
            Console.WriteLine("*someone dump the water on Atia’s head* <splash> ‘oops I didn’t  see you coming’//laugh//");
            Console.WriteLine();
            Console.WriteLine("Your shouldn’t be surprised that Atia got a splash and he wasn't even mad about it.\nUnfortunately this kind of situation always happens to him.\nAnd it’s the best way to avoid having any more problems by just ignoring it.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Atia - *ignore what just happens and try to walk away*");
            Console.ReadKey();
            Console.WriteLine("Zephirah - Hey! you there");
            Console.ReadKey();
            Console.WriteLine("Atia - What NOW!!!! //very angry,annoyed//");
            Console.ReadKey();
            Console.WriteLine("Zephirah - How dare you use that tone with me,powerless like you is just useless trash you didn't deserve to get in the academy");
            Console.ReadKey();
            Console.WriteLine("What will you do next?");
            Console.WriteLine("1.)Yes after all you're right");
            Console.WriteLine("2.)WHAT DID YOU JUST SAY!! *Punch zephirah*");
            Console.WriteLine("*Type only '1' or '2'*");
            Console.Write("Choice: ");
            choice2 = Console.ReadLine().ToLower();

            switch (choice2)
            {
                case "1":
                    {
                        Console.WriteLine();
                        Console.WriteLine("Atia gave up and fall down to his knee just sitting silently the ground until Zephirah goes away.");
                        Console.WriteLine("Turn out that after Atia gave up he has to bare with bullying everyday for 6 years.");
                        Console.WriteLine("Yes,literally everyday even to the day he graduate and that day might be the happiest day of his highschool life.");
                        Console.ReadLine();
                        End1();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine();
                        Console.WriteLine("Atia - What did you say *punch Zephirah* <hit sound>");
                        Console.ReadLine();
                        Con3();
                        break;
                    }
                default:
                    {

                        Console.WriteLine();
                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        Console.Clear();
                        Con2();
                        break;

                    }

            }
        }


        public static void Con3()
        {

            Console.WriteLine("Zephirah - //Grrrr// HOW!!!! DARE!!!! YOU!!!! *push Atia*");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Did you forget what i said 'USELESS' * begin to use his fire power *");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Trash like you should get teach by hard lesson *raise his fire and shoot the fireball to Atia*");
            Console.ReadLine();
            Console.WriteLine("Atia-scaredly use his arm to cover himself");
            Console.ReadLine();
            Console.WriteLine("*Not thing happen* //?????//");
            Console.ReadLine();
            Console.WriteLine("Someone - Student!!!,Stop what you’re  doing if you don't want to get in trouble");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Run before Teacher sees us!!*simultaneously run away with his underling");
            Console.ReadLine();
            Console.WriteLine("*Atia thinking*\nAtia - //why didn't i feel any heat//");
            Console.ReadLine();
            Console.WriteLine("Addam - Hey are you okay?");
            Console.ReadLine();
            Console.WriteLine("Atia - U..Umm I'm fine but you are not a teacher?");
            Console.ReadLine();
            Console.WriteLine("Addam - oh I just want to make them scared. Are you really okay?I thought you got hit by that fire");
            Console.ReadLine();
            Console.WriteLine("Atia - Uh...just a little hot it didn't burn me to ash so i think i'm okay");
            Console.ReadLine();
            Console.WriteLine("Addam - You should go to the infirmary");
            Console.ReadLine();
            Console.WriteLine("Atia - Um,thank …?");
            Console.ReadLine();
            Console.WriteLine("Addam - Oh i forget to introduce myself by the way i'm addam.");
            Console.ReadLine();
            Console.WriteLine("Atia - I'm..");
            Console.ReadLine();
            Console.WriteLine("Addam - Oh i forget to introduce myself by the way i'm addam.");
            Console.ReadLine();
            Console.WriteLine("Addam - I already know your name actually everyone know your name");
            Console.ReadLine();
            Console.WriteLine("Atia - Really?!?!?!?!?!?!");
            Console.ReadLine();
            Console.WriteLine("Addam - I gotta go,see ya later");
            Console.ReadLine();
            Console.WriteLine("Atia - Bye");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-In the evening-");
            Console.ReadLine();
            Console.WriteLine("Atia - *walking to his dorm *");
            Console.ReadLine();
            Console.WriteLine("Atia - What happen when I got shot by that fireball why didn't I get hurt not even a burnt wound just a small bruise");
            Console.WriteLine("Atia - *I should have punch him another time even i don't have power i can punch him in the face,That bastard*");
            Console.WriteLine();
            Console.WriteLine("At that time when Atia think about fight between him and Zephirah.");
            Console.WriteLine("He accidently wake his power up and fire was lit on his hand.");
            Console.ReadLine();
            Console.WriteLine("Atia - What the duck just happen\n*shake his hand until the fire goes out* //may be my power has awaken//");
            Console.WriteLine();
            Console.WriteLine("To Be Continued....");
            Console.Clear();
            Con4();

        }

        public static void Con4()
        {
            string choice3;

            Console.WriteLine("-The Next Day-");
            Console.WriteLine();
            Console.WriteLine("!!!!!!CRASH!!!!!");
            Console.ReadKey();
            Console.WriteLine("Zephirah - I will kill you. Do you think you can tricked me and still live peacefully in this academy?!?");
            Console.ReadKey();
            Console.WriteLine("Addam - But you bully him first");
            Console.ReadKey();
            Console.WriteLine("Zephirah - So you think you can be a knight and help that useless princess then you have  to take the responsibility from what you have made");
            Console.ReadKey();
            Console.WriteLine("Addam - Woah!!!");
            Console.ReadKey();
            Console.WriteLine("Zephirah - *Throw fireball and slightly hit and burn  addam*");
            Console.ReadKey();
            Console.WriteLine("Zephirah - If you get in my way again it won't be just a little burn");
            Console.ReadKey();
            Console.WriteLine("Addam - .....");
            Console.ReadKey();
            Console.WriteLine("Atia - *accidentally walk into addam*");
            Console.ReadKey();
            Console.WriteLine("Atia - Hey! what happen to you?");
            Console.ReadKey();
            Console.WriteLine("Addam - Nothing, Zephirah just want to take revenge on me cause I tricked him");
            Console.ReadKey();
            Console.WriteLine("Atia - Did you get hurt because of me I'll bring you to infirmary");
            Console.ReadKey();
            Console.WriteLine("Addam - It's fine I can fix this");
            Console.ReadKey();
            Console.WriteLine("Addam - You know the primitive way some herb and I’m as good as new born baby");
            Console.WriteLine("*Addam use his healing magic and heal his wound with herb*");
            Console.ReadKey();
            Console.WriteLine("Atia - wow you can use herb medicine magic?!?");
            Console.ReadKey();
            Console.WriteLine("Addam - Yup,don't worry about me he didn't do that because of you");
            Console.ReadKey();
            Console.WriteLine("Atia - so are we friends now?");
            Console.ReadKey();
            Console.WriteLine("Addam - SURE! Actually I'm from another town I don't have any friends yet I'm glad to have you as a friend");
            Console.ReadKey();
            Console.WriteLine("Atia - me too!");
            Console.ReadKey();
            Console.WriteLine("Atia and Addam take their time and pretend like greeting each other in the first time they met.\nWhile they holding hand of each other the saw a green light from Atia hand");
            Console.ReadKey();
            Console.WriteLine("Addam - !!!!!!!!");
            Console.ReadKey();
            Console.WriteLine("Atia - What is that??");
            Console.ReadKey();
            Console.WriteLine("Addam - Oh! that’s my power");
            Console.ReadKey();
            Console.WriteLine("Atia - What??");
            Console.ReadKey();
            Console.WriteLine("Addam - Look like you are not powerless anymore");
            Console.ReadKey();
            Console.WriteLine("Atia - It show up yesterday and suddenly fire was lit on my hand");
            Console.ReadKey();
            Console.WriteLine("Addam - Really? I think I know what your power is");
            Console.ReadKey();
            Console.WriteLine("Atia - What is it?");
            Console.ReadKey();
            Console.WriteLine("Addam - Your power is 'copy' i used to study about it for awhile.\nYou can keep other person's power as yours but i'm not sure how it works");
            Console.ReadKey();
            Console.WriteLine("Atia - If i could use this power when Zephirah bully me at least\nI could block his power and I think it’s great to have power likes yours");
            Console.ReadKey();
            Console.WriteLine("Addam - Eh? you want my power isn't that  ultimately over power?!!!\nWhatever what are you going to do with that should you tell the teacher");
            Console.ReadKey();
            Console.WriteLine("Atia - Nah if I told the teacher then it wouldn't be interesting I have better idea ");
            Console.ReadKey();
            Console.WriteLine("Addam - What is it then?");

            Console.WriteLine("What will you do next?");
            Console.WriteLine("1.)I will take a huge revenge on them");
            Console.WriteLine("2.)I will show my true power to everyone");
            Console.WriteLine("*Type only '1' or '2'*");
            Console.Write("Choice: ");
            choice3 = Console.ReadLine().ToLower();

            switch (choice3)
            {
                case "1":
                    {
                        Con5();
                        break;
                    }
                case "2":
                    {
                        Con6();
                        break;
                    }
                default:
                    {

                        Console.WriteLine();
                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        Console.Clear();
                        Con2();
                        break;

                    }

            }

        }

        public static void Con5()
        {

            string choice5;

            Console.WriteLine("Atia - I will take a huge revenge on them!!");
            Console.ReadLine();
            Console.WriteLine("Addam - So what is your plan?");
            Console.ReadLine();
            Console.WriteLine("Atia - Oh! that's right!");
            Console.ReadLine();
            Console.WriteLine("Addam - You aren't just gonna pick a fight with them right?");
            Console.ReadLine();
            Console.WriteLine("Atia - No That too easy");
            Console.ReadLine();
            Console.WriteLine("Addam - So what?");
            Console.ReadLine();
            Console.WriteLine("Atia - They have been bully me since the first day.\nThey always make me feel anxious and worthless.\nAnd I want to make them feel the same or evenworse * hold his fist tight *");
            Console.ReadLine();
            Console.WriteLine("Addam - ........");
            Console.ReadLine();
            Console.WriteLine("Atia - I will tell you when I finished planing");
            Console.ReadLine();
            Console.WriteLine("Addam - Alright");
            Console.ReadLine();
            Console.WriteLine("Atia - We should go to the class");
            Console.ReadLine();
            Console.WriteLine("Addam - See you there.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-In the classroom-");
            Console.ReadLine();
            Console.WriteLine("Teacher - Times up! *students walk out of the classroom*");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Hi trash! *Throw something at Atia*");
            Console.ReadLine();
            Console.WriteLine("Atia - Dude! what Is your problem?");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Why? what you gonna do with that?");
            Console.ReadLine();
            Console.WriteLine("Atia - Useless USELESS IS THAT ALL YOU CAN SAY WITH THAT DIRTY MOUTH.\nGuys like you who hurt other people feeling is worse that the most useless trash.\nEven evendisables are more worthy than you");
            Console.ReadLine();
            Console.WriteLine("Zephirah - What did y...");
            Console.ReadLine();
            Console.WriteLine("Atia - Why? Is it hurt?or if you can’t hear that I can say it all over again");
            Console.ReadLine();
            Console.WriteLine("Zephirah - *fire was lot on his coat* What the!!! where did that came from? YOU DID THAT?!!? *point at Atia*");
            Console.ReadLine();
            Console.WriteLine("Atia - Right! How was that? Now that i have your power Do you still call me useless");
            Console.ReadLine();
            Console.WriteLine("Zephirah - You!!!");
            Console.WriteLine();
            Console.WriteLine("*Both use their power to fight each other,zephirah’s underling try to help zephirah but manage to counter zephirah attack *");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Hey  what are you doing hurry up and help me!!\n*he talk to his underling but it turn out his inderling has already ran away*");
            Console.ReadLine();
            Console.WriteLine("Zephirah - What are you doing!!!");
            Console.ReadLine();
            Console.WriteLine("Atia - in the end all of your friends abandoned you how pathetic.");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Uugh are you going to kill me then hurry up.");
            Console.ReadLine();
            Console.WriteLine("Atia - *going to use his power to kill zephirah");
            Console.ReadLine();
            Console.WriteLine("Zephirah - *close his eye and shake in fear* *arrrrr got burn just a little*\nZephirah - W..Why?");
            Console.ReadLine();
            Console.WriteLine("Atia - You may forget that I’m not like you I'm way better.\nI won't use my power to harm anybody who can’t protect themself like you did.\n* walks away *");
            Console.ReadLine();
            Console.WriteLine("Zephirah - .....");
            Console.ReadLine();
            Console.WriteLine("Atia - *walks away without turning back at his enemy*");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-After school-");
            Console.ReadLine();
            Console.WriteLine("Addam - Hey!");
            Console.ReadLine();
            Console.WriteLine("Atia - Hey!");
            Console.ReadLine();
            Console.WriteLine("Atia - .....");
            Console.ReadLine();
            Console.WriteLine("Addam - Are everything alright?");
            Console.ReadLine();
            Console.WriteLine("Atia - Nothing I just.... I don't know");
            Console.ReadLine();
            Console.WriteLine("Addam - Hey I can not know it by myself you have to tell me");
            Console.ReadLine();
            Console.WriteLine("Atia remembering of his friend 'Sundei' out of nowhere");
            Console.ReadLine();
            Console.WriteLine("Atia - //What am I doing at that time when my friend can't pass the ritual test...");
            Console.WriteLine();
            Console.WriteLine("What was your choice which you choose at the begining");
            Console.WriteLine("1.)Comfort your friend");
            Console.WriteLine("2.)Tell the instructor that the result had an error");
            Console.WriteLine("*Type only '1' or '2'*");
            Console.Write("Choice: ");
            choice5 = Console.ReadLine().ToLower();

            switch (choice5)
            {
                case "1":
                    {
                        Console.WriteLine("Atia - It just... *tells what he has done with Zephirah *");
                        Console.WriteLine("Atia - But I afraid that I'm gonna become someone like him in a fight.\nI feel really satisfied that I get to revenge him when I knew I have power to I feel overwhelmed and feel like I'm better than other.\nI don't want to feel like this");
                        Console.ReadLine();
                        Console.WriteLine("Addam - Calm down I know your not that kind of person even just know you for a while");
                        Console.ReadLine();
                        Console.WriteLine("Atia - But...");
                        Console.ReadLine();
                        Console.WriteLine("Addam - Listen,when you feel good that you get a revenge on someone is normal it doesn't mean you’re a bad person.\nYou have the right to angry when you got bullied and feel good that you get a revenge on someone because you have feeling");
                        Console.ReadLine();
                        Console.WriteLine("Atia - ....");
                        Console.ReadLine();
                        Console.WriteLine("Addam - Then you should go out and help people who got bullied so no one will feel like you");
                        Console.ReadLine();
                        Console.WriteLine("Atia - Is that about our conversation?");
                        Console.ReadLine();
                        Console.WriteLine("Addam - I don't know but do you want people to get bully?");
                        Console.ReadLine();
                        Console.WriteLine("Atia - No !");
                        Console.ReadLine();
                        Console.WriteLine("Addam - Then go and help them just like I did to you you may be good at that");
                        Console.ReadLine();
                        Console.WriteLine("Atia - Alright,I’ll help people who suffer from the fact that they don't have the power");
                        Console.ReadLine();
                        Console.Clear();
                        End1();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Atia - It just... *tells what he has done with Zephirah *");
                        Console.WriteLine("Atia - After all I awaken my power and took a revenge on Zephirah.\nBut what about people put there who doesn't have the power to protect themself?\nThey still need this stupid power just to have a peaceful life.");
                        Console.ReadLine();
                        Console.WriteLine("Addam - I know what you mean but this is how the world has alway been.\nThere is no equality in this mad society full of greedy people everybody only care about themself.\nBut I'm sure that one day in the future may be in a decade it’s going to be better because people like you Atia.\nPeople who really care about other and I think it’s good that you didn't do anything serious to Zephirah");
                        Console.ReadLine();
                        Console.WriteLine("Atia - ...Hey");
                        Console.ReadLine();
                        Console.WriteLine("Addam - ????");
                        Console.ReadLine();
                        Console.WriteLine("Atia - What if i don't want to wait...");
                        Console.ReadLine();
                        Console.WriteLine("Addam - What do you mean? *confuse*");
                        Console.ReadLine();
                        Console.WriteLine("Atia - I'm gonna change the world so people would have to wait for their happiness");
                        Console.ReadLine();
                        Console.WriteLine("Addam - H..huh?You know that’s not gonna be easy right?");
                        Console.ReadLine();
                        Console.WriteLine("Atia - I know but we can start in a small scale first such as our class and then go bigger and bigger.\nUntil we reach the national level.what do you think?");
                        Console.ReadLine();
                        Console.WriteLine("Addam - .... *thinking* Okay I’m in,I’ll help you get to your goal");
                        Console.ReadLine();
                        Console.WriteLine("Atia - I knew you will *hug Addam*");
                        Console.ReadLine();
                        Console.Clear();
                        End1();
                        break;
                    }
                default:
                    {

                        Console.WriteLine();
                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        Console.Clear();
                        Con2();
                        break;

                    }

            }

        }

        public static void Con6()
        {

            Console.WriteLine("Atia - I will show my true power to people");
            Console.ReadLine();
            Console.WriteLine("Addam - So how are you going to do it?");
            Console.ReadLine();
            Console.WriteLine("Atia - Let me think");
            Console.ReadLine();
            Console.WriteLine("Addam - Oh! there is another ritual test next week");
            Console.ReadLine();
            Console.WriteLine("Atia - so? *confused*");
            Console.ReadLine();
            Console.WriteLine("Addam - You don't really know? You can show your power there at the test.");
            Console.ReadLine();
            Console.WriteLine("Atia - But How exactly?");
            Console.ReadLine();
            Console.WriteLine("Addam - Don't you know this isn't a normal power test.");
            Console.ReadLine();
            Console.WriteLine("Atia-What do you mean?");
            Console.ReadLine();
            Console.WriteLine("Addam - We have to show our power,actually as much as you could and the machine will calculate your power into percentage");
            Console.ReadLine();
            Console.WriteLine("Atia - Woah");
            Console.ReadLine();
            Console.WriteLine("Addam - Now that you have Zephirah and mine power that's more than enough to show off I’ll research abit more");
            Console.ReadLine();
            Console.WriteLine("Atia - Thanks bud!");
            Console.ReadLine();
            Console.WriteLine("Addam - My pleasure! you should go to you class before you are late see you tomorrow");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-The next day-");
            Console.ReadLine();
            Console.WriteLine("Atia - Do you have any new information about my power?");
            Console.ReadLine();
            Console.WriteLine("Addam - There are very very little information about yours power.\nThe only thing I got is you can use your power only when the owner of the power you’ve copied");
            Console.ReadLine();
            Console.WriteLine("Atia - Ok!I also got some information");
            Console.ReadLine();
            Console.WriteLine("Addam - What is it?");
            Console.ReadLine();
            Console.WriteLine("Atia - There is a limit on how much I can use the power I copied.\nAnd I already ran out of your power * sorry face *");
            Console.ReadLine();
            Console.WriteLine("Addam - ........ fine So I have to use my power again?");
            Console.ReadLine();
            Console.WriteLine("Atia - Yup Thanks buddy!");
            Console.ReadLine();
            Console.WriteLine("Addam - alright I will use my power now");
            Console.ReadLine();
            Console.WriteLine("Atia - Thank again");
            Console.ReadLine();
            Console.WriteLine("Addam - It’s only a few days left before the test begin you should copied as much power as you could");
            Console.ReadLine();
            Console.WriteLine("Atia - I think it’s already enough");
            Console.ReadLine();
            Console.WriteLine("Addam - Trust me you’ll need it soon");
            Console.ReadLine();
            Console.WriteLine("Atia - Okay");
            Console.ReadLine();
            Console.WriteLine("Meanwhile other students practice their power for the test.\nAtia use that opotunity to collect as much power as he could");
            Console.ReadLine();
            Console.WriteLine("-The test day-");
            Console.ReadLine();
            Console.WriteLine("Every body use all thier power for the test some got preferably score but sadly most didn't.\nThe test get attention from everybody so the test site is always full of people the crowd that came to see the test result was entertaining.\nAlthough the day and it came to the last test participant but they didn't expect to see anything from this participant because he is “Atia”.\nA man who got called for entire life as a 'useless trash'");
            Console.ReadLine();
            Console.WriteLine("Teacher - This is our last participant Let’s end this test *annoyed*\n//Why did this kid even take the test he doesn't have any power I wonder how he even got into the academy//");
            Console.ReadLine();
            Console.WriteLine("Other student - Isn’t that student don't have any power *laugh*\nHe is going to humiliate himself in front of the whole academy * pitty *");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Haha! I already feel bad for h....");
            Console.ReadLine();
            Console.WriteLine("Teacher - 95 %!! The most of all!!");
            Console.ReadLine();
            Console.WriteLine("Zephirah - Did he had the power all along?");
            Console.ReadLine();
            Console.WriteLine("Atia - I accidently get this power and by 'this power'\nI mean 'your power' *smile * Are you surprised about that ?");
            Console.ReadLine();
            Console.WriteLine("Zephirah - .....");
            Console.ReadLine();
            Console.WriteLine("Other student - .....");
            Console.ReadLine();
            Console.WriteLine("Teacher - What do you mean?");
            Console.ReadLine();
            Console.WriteLine("Atia - I’m not sure but as far as I and my friend know it seems like keeping other people power as mine");
            Console.ReadLine();
            Console.WriteLine("Teacher - Keep the power? I thought I was just a rumor. can you help us to research about that ?");
            Console.ReadLine();
            Console.WriteLine("Atia - Yes, I could.");
            Console.ReadLine();
            Console.WriteLine("Teacher - I’ll the principal first come and see me after school");
            Console.ReadLine();
            Console.WriteLine("Atia - Okay, sir");
            Console.ReadLine();
            Console.WriteLine("Atia - *turn to his classmate* Will you still call me useless after seeing my power.\nNow you are all using useless compare to me I hope you enjoy that * smile*");
            Console.ReadLine();
            End1();

        }


        public static void End1()
        {

            string choiceE;
            string choiceEL;

            Console.Clear();
            Console.WriteLine("The game has ended.");
            Console.WriteLine("If you want to know more path of this story you have to played another route.\nIn this game have 4 ending.");
            Console.WriteLine("Do you want to reset?");
            Console.WriteLine("You can awnswer only 'Yes' or 'No'");
            Console.Write("Choice: ");
            choiceE = Console.ReadLine().ToLower();

            switch (choiceE)
            {
                case "Yes":
                case "yes":
                    {
                        Console.WriteLine();
                        Console.WriteLine("Let's do this again fellas!");
                        Console.ReadLine();
                        Console.Clear();
                        Prologue();
                        break;
                    }
                case "No":
                case "no":
                    {
                        Console.WriteLine();
                        Console.WriteLine("This will close your program are you sure?");
                        Console.WriteLine("You can awnswer only 'Yes' or 'No'");
                        Console.Write("Choice: ");
                        choiceEL = Console.ReadLine().ToLower();

                        switch (choiceEL)
                        {
                            case "Yes":
                            case "yes":
                                {
                                    Environment.Exit(0);
                                    break;
                                }
                            case "No":
                            case "no":
                                {
                                    End1();
                                    break;
                                }
                            default:
                                {

                                    Console.WriteLine();
                                    Console.WriteLine("Command is invalid...");
                                    Console.WriteLine("Press 'Enter' to restart.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    End1();
                                    break;

                                }

                        }

                        break;
                    }
                default:
                    {

                        Console.WriteLine();
                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        Console.Clear();
                        End1();
                        break;
                    }

            }


        }

    }

}