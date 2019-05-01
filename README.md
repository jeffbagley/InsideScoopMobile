Inside Scoop
Created by Jeff Bagley, Cordell Appel, and Courtney Appel
Under the guidance of Geoff Gilbert


Information:
Inside Scoop is a mobile application designed to help connect food trucks and other mobile food vendors with those who want to visit them. The application is cross-platform for iOS and Android and is currently in development/testing. The main features of the application include a map that updates in real-time to show current locations of food trucks in your area, as well as a number of smaller features such as different pages for each truck, ratings, favorites, and more.

Programming Environment:
Inside Scoop was written in C# and XAML using a programming environment called Xamarin Forms in Microsoft Visual Studio. The link to download Xamarin is here: https://visualstudio.microsoft.com/xamarin/

Database: We created a number of databases to use in conjunction with Inside Scoop, however, currently none are functioning properly. We have a database set up with Microsoft Azure which is able to connect to Xamarin easily (in theory). If anyone is looking to access this database, feel free to email Jeff at jefferson.bagley@umontana.edu and we will be happy to work with you to get you access to this database. Information about connecting a database to xamarin can be found here: https://stackoverflow.com/questions/46015474/how-to-connect-a-xamarin-app-to-a-sql-azure-db. I would recommend creating a database from scratch rather than use ours on Azure, but we are always happy to help if we can.

Notes:
-Xamarin has many useful features but can be a bit buggy at times. It may require frequent updates but hopefully that is fixed soon. 
-The purpose of Xamarin is to create applications that are cross-platform with a single shared code base. While this would be great, it may be better in practice to create separate applications in different environments such as Java/Swift. Currently, the iOS version is the most polished, but the Android version has functionality as well. 
-Currently, many items that should be pulled from a database are hard-coded such as pin locations and the list view as well. These can easily be replaced by information pulled from the database once it is functioning properly.
-The images used should be uploaded both as .png/.jpg files as well as adobe illustrator base files for the sake of convenience in editing/making changes to the files.
-To run, run the insidescoopmobile.sln file in Visual Studio.

Contact:
jefferson.bagley@umontana.edu
courtneyappel@gmail.com

