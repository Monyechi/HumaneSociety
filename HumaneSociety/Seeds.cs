using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Seeds
    {
        // Clients
        INSERT INTO Clients VALUES('Scott', 'Malcanson', 'R.Scott89', 'willynilly823', 1, 'Rick_Scott@fla.gov');
        INSERT INTO Clients VALUES('Bob', 'Sagit', 'R.Scott89', 'Saggit', 2, 'Sag@mag.com');
        INSERT INTO Clients VALUES('Rango', 'Scott', 'R.Scott89', 'RangoBango', 3, 'rangobango@hotmail.com');
        INSERT INTO Clients VALUES('Billy-Bob', 'Hornton', 'billybHornton', 'nillywilly374', 4, 'billybob@mail.com');
        INSERT INTO Clients VALUES('George', 'Tonhorn', 'gtzoom', 'GeorgeBorge3rdr', 5, 'gjucice@hotmoose.com');


        // Addresses
        INSERT INTO Addresses VALUES('925 MemorialPark', 'Jacksonville', 9, 32256);
        INSERT INTO Addresses VALUES('315 OceanDrive ', 'Miami', 9, 32257);
        INSERT INTO Addresses VALUES('8701 MistrailCourt', 'Jacksonville', 9, 33392);
        INSERT INTO Addresses VALUES('113 ForbesStreet', 'WhiteSprings', 9, 22252);
        INSERT INTO Addresses VALUES('2232 ForbesStreet', 'WhiteSprings', 9, 22252);

        // Animals
        INSERT INTO Animals VALUES(‘Lily’, 32, 3, ‘Calm’, 1, 1, ‘Female’, ‘LookingForHome’, 1, 1, 1);
        INSERT INTO Animals VALUES(‘Harry’, 15, 4, ‘Playful’, 1, 1, ‘Female’, ‘LookingForHome’, 2, 2, 2);
        INSERT INTO Animals VALUES(‘Stache’, 18, 5, ‘Playful’, 1, 1, ‘Male’, ‘LookingForHome’, 3, 5, 3);
        INSERT INTO Animals VALUES(‘Henry’, 3, 2, ‘Loud’, 1, 2, ‘Male’, ‘JustAdopted’, 8, 3, 4);
        INSERT INTO Animals VALUES(‘Jackie’, 12, 4, ‘Quiet’, 1, 1, ‘Female’,‘PreAdopted’, 9, 4, 5);

        // Rooms
        INSERT INTO Rooms VALUES(1, 4);
        INSERT INTO Rooms VALUES(2, 5);
        INSERT INTO Rooms VALUES(3, 6);
        INSERT INTO Rooms VALUES(4, 7);
        INSERT INTO Rooms VALUES(5, 8);

        // Employees
        INSERT INTO Employees VALUES('John', 'Doe', 'Jdoe25', 'DrakeFan123', 7654325, 'JohnDoe@hotmail.com');
        INSERT INTO Employees VALUES('Jane', 'Doe', 'Janedoe25', 'WippleHipple655', 973468, 'JaneDoe@hotmail.com');
        INSERT INTO Employees VALUES('James', 'Doe', 'JamesD87', 'Jdogg187', 6664325, 'JamesBong@hotmail.com');
        INSERT INTO Employees VALUES('Jarell', 'Doe', 'Jrelldoe95', 'hotHIzzleForsshizle', 223525, 'RellBell@hotmail.com');
        INSERT INTO Employees VALUES('Lucy', 'Shoemaker', 'L.Shoemaker', 'CovfefeGood', 407642, 'IdontMakeShoes@hotmail.com');


        // Diet Plans

        INSERT INTO DietPlans VALUES('KIBBLES & BITS', 'DOG', '5');
        INSERT INTO DietPlans VALUES('MEOW MIX', 'CAT', '5');
        INSERT INTO DietPlans VALUES('MIXED SEED', 'BIRD', '3');
        INSERT INTO DietPlans VALUES('CRICKETS', 'LIZARDS', '15');
        INSERT INTO DietPlans VALUES('VEGETABLES', 'RABBITS', '7');

        // Categories
        INSERT INTO Categories VALUES('DOGS');
        INSERT INTO Categories VALUES('CATS');
        INSERT INTO Categories VALUES('RABBITS');
        INSERT INTO Categories VALUES('BIRDS');
        INSERT INTO Categories VALUES('LIZARDS');
    }
}
