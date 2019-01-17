using System;
using System.Collections.Generic;
using System.Text;

namespace Dobble.Domain
{
    public class Cards
    {

        public List<Card> lijst = new List<Card>()
        {
           
            new Card { picturelist = new List<string>() { "1",  "49",  "9", "27","10","37","2" ,"20"} },
            new Card { picturelist = new List<string>() { "10", "34", "47", "54","26","24","12","55"}},
            new Card { picturelist = new List<string>() { "42", "31", "43",  "2","11", "21", "53","34" }},
            new Card { picturelist = new List<string>() { "21", "48", "15", "37","8","3", "7", "12"}},
            new Card { picturelist = new List<string>() { "21", "20", "28","16","13", "47", "57", "5"}},
            new Card { picturelist = new List<string>() { "32", "50", "9", "17","19", "52", "21", "24"}},
            new Card { picturelist = new List<string>() { "21", "33", "18", "14", "38", "10", "25", "44"}},
            new Card { picturelist = new List<string>() { "57", "24", "33", "35", "48", "2", "6", "22"}},
            new Card { picturelist = new List<string>() { "36", "32", "7", "2", "13", "56", "14", "55"}},
            new Card { picturelist = new List<string>() {"50", "18", "42", "51", "36", "26", "20", "48"}},
            new Card { picturelist = new List<string>() {"23", "39", "36", "43","33","9", "47","8" } },
            new Card { picturelist = new List<string>() {"46", "19", "6", "18", "47", "27", "53", "7" } },
            new Card { picturelist = new List<string>() {"33", "54", "41", "56","15", "19", "20", "11"}},
            new Card { picturelist = new List<string>() {"36", "35", "11", "27","17","25","12","5" }},
            new Card { picturelist = new List<string>() {"50", "38", "46","3","5", "54","2","23"}},
            new Card { picturelist = new List<string>() {"11", "13", "6", "37","44","52","26", "23"} },
            new Card { picturelist = new List<string>() {"36", "24", "16", "49", "41", "53", "44", "3" }},
            new Card { picturelist = new List<string>() {"51", "24", "28", "1", "14","11", "46", "8" }},
            new Card { picturelist = new List<string>() {"49", "50", "6", "15","55","25","28","43" }},
            new Card { picturelist = new List<string>() {"45", "3", "11", "9", "4", "18", "57", "55"}},
            new Card { picturelist = new List<string>() {"27", "8", "44", "30", "50", "57", "56", "34" }},
            new Card { picturelist = new List<string>() {"57", "14", "12", "19", "23", "49","29","42"}},
            new Card { picturelist = new List<string>() {"20", "8", "52","35","29", "38", "55","53"} },
            new Card { picturelist = new List<string>() {"51", "12", "38", "56","6","9","16","31" }},
            new Card { picturelist = new List<string>() {"36","31", "57", "15", "40", "10", "46","52"}},
            new Card { picturelist = new List<string>() {"40","25","8","45","19", "26", "2","16"}},
            new Card { picturelist = new List<string>() {"29","56","37","5", "24","43", "18", "40"}},
            new Card { picturelist = new List<string>() {"21", "54", "1","6", "29", "30", "45", "36"} },
            new Card { picturelist = new List<string>() {"14","26","9","15","22","53","5", "30" }},
            new Card { picturelist = new List<string>() {"46","39","21","26","35","49","56","4" }},
            new Card {picturelist = new List<string>() {"46","30", "37", "33", "16", "42","55","17"}},
            new Card {picturelist = new List<string>() {"28","23","48","56","10","53","17","45"}},
            new Card {picturelist = new List<string>() {"52", "30", "39","28","2","41","18","12"}},
            new Card {picturelist = new List<string>() {"51","23","21", "41", "27","40","55","22"} },
            new Card {picturelist = new List<string>() {"57","17", "26","7","43","1","41","38"}},
            new Card {picturelist = new List<string>() {"25", "3","52","1","56","47","22","42"}},
            new Card {picturelist = new List<string>() {"39", "13","42","27","15","38","45","24" }},
            new Card {picturelist = new List<string>() {"39", "44","48","1","31","5","55","19"}},
            new Card {picturelist = new List<string>() {"29","34","25","46","48","9","13","41"}},
            new Card {picturelist = new List<string>() {"29", "17","15","51","44","2","47","4"}},
            new Card {picturelist = new List<string>() {"16", "4", "27", "43", "54","14","52","48" }},
            new Card {picturelist = new List<string>() {"42", "40", "44", "28", "54","35","7", "9" }},
            new Card {picturelist = new List<string>() {"22", "12","45","46","20","32","43","44" }}
        };




        public List<Card> list = new List<Card>() {
         new Card
        {
            
            picture1 = "1",
            picture2 = "49",
            picture3 = "9",
            picture4 = "27",
            picture5 = "10",
            picture6 = "37",
            picture7 = "2",
            picture8 = "20"
        },
           new Card
        {
            picture1 = "10",
            picture2 = "34",
            picture3 = "47",
            picture4 = "54",
            picture5 = "26",
            picture6 = "24",
            picture7 = "12",
            picture8 = "55"
        },
          new Card
        {
            picture1 = "42",
            picture2 = "31",
            picture3 = "43",
            picture4 = "2",
            picture5 = "11",
            picture6 = "21",
            picture7 = "53",
            picture8 = "34"
        },
          new Card
        {
            picture1 = "21",
            picture2 = "48",
            picture3 = "15",
            picture4 = "37",
            picture5 = "8",
            picture6 = "3",
            picture7 = "7",
            picture8 = "12"
        },
          new Card
        {
            picture1 = "21",
            picture2 = "20",
            picture3 = "28",
            picture4 = "16",
            picture5 = "13",
            picture6 = "47",
            picture7 = "57",
            picture8 = "5"
        },
          new Card
        {
            picture1 = "32",
            picture2 = "50",
            picture3 = "9",
            picture4 = "17",
            picture5 = "19",
            picture6 = "52",
            picture7 = "21",
            picture8 = "24"
        },
          new Card
        {
            picture1 = "21",
            picture2 = "33",
            picture3 = "18",
            picture4 = "14",
            picture5 = "38",
            picture6 = "10",
            picture7 = "25",
            picture8 = "44"
        },
          new Card
        {
            picture1 = "57",
            picture2 = "24",
            picture3 = "33",
            picture4 = "35",
            picture5 = "48",
            picture6 = "2",
            picture7 = "6",
            picture8 = "22"
        },
          new Card
        {
            picture1 = "36",
            picture2 = "32",
            picture3 = "7",
            picture4 = "2",
            picture5 = "13",
            picture6 = "56",
            picture7 = "14",
            picture8 = "55"
        },
          new Card
        {
            picture1 = "50",
            picture2 = "18",
            picture3 = "42",
            picture4 = "51",
            picture5 = "36",
            picture6 = "26",
            picture7 = "20",
            picture8 = "48"
        },
          new Card
        {
            picture1 = "23",
            picture2 = "39",
            picture3 = "36",
            picture4 = "43",
            picture5 = "33",
            picture6 = "9",
            picture7 = "47",
            picture8 = "8"
        },
          new Card
        {
            picture1 = "46",
            picture2 = "19",
            picture3 = "6",
            picture4 = "18",
            picture5 = "47",
            picture6 = "27",
            picture7 = "53",
            picture8 = "7"
        },
         new Card
        {
            picture1 = "33",
            picture2 = "54",
            picture3 = "41",
            picture4 = "56",
            picture5 = "15",
            picture6 = "19",
            picture7 = "20",
            picture8 = "11"
        },
         new Card
        {
            picture1 = "36",
            picture2 = "35",
            picture3 = "11",
            picture4 = "27",
            picture5 = "17",
            picture6 = "25",
            picture7 = "12",
            picture8 = "5"
        },
         new Card
        {
            picture1 = "50",
            picture2 = "38",
            picture3 = "46",
            picture4 = "3",
            picture5 = "5",
            picture6 = "54",
            picture7 = "2",
            picture8 = "23"
        },
          new Card
        {
            picture1 = "11",
            picture2 = "13",
            picture3 = "6",
            picture4 = "37",
            picture5 = "44",
            picture6 = "52",
            picture7 = "26",
            picture8 = "23"
        },
          new Card
        {
            picture1 = "36",
            picture2 = "24",
            picture3 = "16",
            picture4 = "49",
            picture5 = "41",
            picture6 = "53",
            picture7 = "44",
            picture8 = "3"
        },
         new Card
        {
            picture1 = "51",
            picture2 = "24",
            picture3 = "28",
            picture4 = "1",
            picture5 = "14",
            picture6 = "11",
            picture7 = "46",
            picture8 = "8"
        },
         new Card
        {
            picture1 = "49",
            picture2 = "50",
            picture3 = "6",
            picture4 = "15",
            picture5 = "55",
            picture6 = "25",
            picture7 = "28",
            picture8 = "43"
        },
         new Card
        {
            picture1 = "45",
            picture2 = "3",
            picture3 = "11",
            picture4 = "9",
            picture5 = "4",
            picture6 = "18",
            picture7 = "57",
            picture8 = "55"
        },
         new Card
        {
            picture1 = "27",
            picture2 = "8",
            picture3 = "44",
            picture4 = "30",
            picture5 = "50",
            picture6 = "57",
            picture7 = "56",
            picture8 = "34"
        },
        new Card
        {
            picture1 = "57",
            picture2 = "14",
            picture3 = "12",
            picture4 = "19",
            picture5 = "23",
            picture6 = "49",
            picture7 = "29",
            picture8 = "42"
        },
        new Card
        {
            picture1 = "20",
            picture2 = "8",
            picture3 = "52",
            picture4 = "35",
            picture5 = "29",
            picture6 = "38",
            picture7 = "55",
            picture8 = "53"
        },
        
        new Card
        {
            picture1 = "51",
            picture2 = "12",
            picture3 = "38",
            picture4 = "56",
            picture5 = "6",
            picture6 = "9",
            picture7 = "16",
            picture8 = "31"
        },
        new Card
        {
            picture1 = "36",
            picture2 = "31",
            picture3 = "57",
            picture4 = "15",
            picture5 = "40",
            picture6 = "10",
            picture7 = "46",
            picture8 = "52"
        },
        new Card
        {
            picture1 = "40",
            picture2 = "25",
            picture3 = "8",
            picture4 = "45",
            picture5 = "19",
            picture6 = "26",
            picture7 = "2",
            picture8 = "16"
        },
        new Card
        {
            picture1 = "29",
            picture2 = "56",
            picture3 = "37",
            picture4 = "5",
            picture5 = "24",
            picture6 = "43",
            picture7 = "18",
            picture8 = "40"
        },
        new Card
        {
            picture1 = "21",
            picture2 = "54",
            picture3 = "1",
            picture4 = "6",
            picture5 = "29",
            picture6 = "30",
            picture7 = "45",
            picture8 = "36"
        },
        new Card
        {
            picture1 = "14",
            picture2 = "26",
            picture3 = "9",
            picture4 = "15",
            picture5 = "22",
            picture6 = "53",
            picture7 = "5",
            picture8 = "30"
        },
        new Card
        {
            picture1 = "46",
            picture2 = "39",
            picture3 = "21",
            picture4 = "26",
            picture5 = "35",
            picture6 = "49",
            picture7 = "56",
            picture8 = "4"
        },
        new Card
        {
            picture1 = "46",
            picture2 = "30",
            picture3 = "37",
            picture4 = "33",
            picture5 = "16",
            picture6 = "42",
            picture7 = "55",
            picture8 = "17"
        },
        new Card
        {
            picture1 = "28",
            picture2 = "23",
            picture3 = "48",
            picture4 = "56",
            picture5 = "10",
            picture6 = "53",
            picture7 = "17",
            picture8 = "45"
        },
        new Card
        {
            picture1 = "52",
            picture2 = "30",
            picture3 = "39",
            picture4 = "28",
            picture5 = "2",
            picture6 = "41",
            picture7 = "18",
            picture8 = "12"
        },
        new Card
        {
            picture1 = "51",
            picture2 = "23",
            picture3 = "21",
            picture4 = "41",
            picture5 = "27",
            picture6 = "40",
            picture7 = "55",
            picture8 = "22"
        },
        new Card
        {
            picture1 = "57",
            picture2 = "17",
            picture3 = "26",
            picture4 = "7",
            picture5 = "43",
            picture6 = "1",
            picture7 = "41",
            picture8 = "38"
        },
        new Card
        {
            picture1 = "25",
            picture2 = "3",
            picture3 = "52",
            picture4 = "1",
            picture5 = "56",
            picture6 = "47",
            picture7 = "22",
            picture8 = "42"
        },
        new Card
        {
            picture1 = "39",
            picture2 = "13",
            picture3 = "42",
            picture4 = "27",
            picture5 = "15",
            picture6 = "38",
            picture7 = "45",
            picture8 = "24"
        },
        new Card
        {
            picture1 = "39",
            picture2 = "44",
            picture3 = "48",
            picture4 = "1",
            picture5 = "31",
            picture6 = "5",
            picture7 = "55",
            picture8 = "19"
        },
        new Card
        {
            picture1 = "29",
            picture2 = "34",
            picture3 = "25",
            picture4 = "46",
            picture5 = "48",
            picture6 = "9",
            picture7 = "13",
            picture8 = "41"
        },
        new Card
        {
            picture1 = "29",
            picture2 = "17",
            picture3 = "15",
            picture4 = "51",
            picture5 = "44",
            picture6 = "2",
            picture7 = "47",
            picture8 = "4"
        },
        new Card
        {
            picture1 = "16",
            picture2 = "4",
            picture3 = "27",
            picture4 = "43",
            picture5 = "54",
            picture6 = "14",
            picture7 = "52",
            picture8 = "48"
        },
        new Card
        {
            picture1 = "42",
            picture2 = "40",
            picture3 = "44",
            picture4 = "28",
            picture5 = "54",
            picture6 = "35",
            picture7 = "7",
            picture8 = "9"
        },
        new Card
        {
            picture1 = "22",
            picture2 = "12",
            picture3 = "45",
            picture4 = "46",
            picture5 = "20",
            picture6 = "32",
            picture7 = "43",
            picture8 = "44"
        },
        new Card
        {
            picture1 = "48",
            picture2 = "11",
            picture3 = "32",
            picture4 = "49",
            picture5 = "47",
            picture6 = "40",
            picture7 = "30",
            picture8 = "38"
        },
        new Card
        {
            picture1 = "33",
            picture2 = "32",
            picture3 = "31",
            picture4 = "29",
            picture5 = "27",
            picture6 = "26",
            picture7 = "3",
            picture8 = "28"
        },
        new Card
        {
            picture1 = "34",
            picture2 = "38",
            picture3 = "37",
            picture4 = "19",
            picture5 = "28",
            picture6 = "4",
            picture7 = "22",
            picture8 = "36"
        },
        new Card
        {
            picture1 = "34",
            picture2 = "14",
            picture3 = "17",
            picture4 = "3",
            picture5 = "40",
            picture6 = "39",
            picture7 = "20",
            picture8 = "6"
        },
        new Card
        {
            picture1 = "42",
            picture2 = "10",
            picture3 = "8",
            picture4 = "5",
            picture5 = "6",
            picture6 = "32",
            picture7 = "41",
            picture8 = "4"
        },
        new Card
        {
            picture1 = "10",
            picture2 = "39",
            picture3 = "16",
            picture4 = "11",
            picture5 = "7",
            picture6 = "50",
            picture7 = "29",
            picture8 = "22"
        },
        new Card
        {
            picture1 = "20",
            picture2 = "7",
            picture3 = "31",
            picture4 = "4",
            picture5 = "30",
            picture6 = "25",
            picture7 = "23",
            picture8 = "24"
        },
        new Card
        {
            picture1 = "34",
            picture2 = "23",
            picture3 = "16",
            picture4 = "35",
            picture5 = "32",
            picture6 = "1",
            picture7 = "18",
            picture8 = "15"
        },
        new Card
        {
            picture1 = "35",
            picture2 = "43",
            picture3 = "51",
            picture4 = "13",
            picture5 = "3",
            picture6 = "19",
            picture7 = "30",
            picture8 = "10"
        },
        new Card
        {
            picture1 = "34",
            picture2 = "51",
            picture3 = "45",
            picture4 = "5",
            picture5 = "52",
            picture6 = "33",
            picture7 = "7",
            picture8 = "49"
        }


        };
       
        
    
    }
}
