# Truck-Logistic

# Introduction

This repository is for private use only! Challenge from the University www.unicorncollege.com

# Input Data

There is a certain amount of goods arriving at the dock, which we can imagine as the number of boxes of the same size (always an integer), for which we do not solve their dimensions or weight for simplicity. At the same time, trucks arriving at the dump are filled with boxes of goods and as soon as they are fully loaded, they leave.

The capacity of one truck is firmly given as 100 boxes.

# Receipt of goods

The file contains information about when a certain number of boxes are delivered to the dock. These two pieces of information are separated by a comma. The information in this file is chronologically sorted. The file does not have a header line. The date is always in the format dd: MM: yyyy hh: mm.

# Arrival of trucks

The file contains information about when the trucks are to be loaded at the dump truck. The truck is not registered for more information. that the name of the truck is a unique identifier. Information, ie date + arrival time and truck name are separated by a comma. The file does not have a header line. The date is in the same format as the product receipt file. The information in this file is chronologically sorted. If more trucks arrive at the same date and time then they are filled in the order they are listed in the file. That is, the one with the lower row number is filled earlier.

#Course of simulation

The task of the program will be to determine the timing of the individual trucks (for the sake of simplicity, we assume that the loading of the boxes in the truck does not take time) so that they can leave. Next, find out how many trucks will fail to fill or how many boxes of goods will remain in the dock because there are not enough trucks to take them off.

Let's show how the program could work 

15.04.2014 12:30, Arrived Kamion Petr, Cargo 0, Note: There are no goods so far so the truck is waiting.
15.04.2014 13:00, Received 45 boxes of goods, Cargo 0, Note: In the truck Peter was immediately loaded 45 boxes, because the truck is waiting on site.
15.04.2014 14:00,	Received 55 boxes of goods, Cargo 0 In the truck Peter was immediately 55 boxes loaded and the truck was full loaded and left, departure time of truck Petr is 15.4.2014 14:00.
15.04.2014 16:00,	Received 110 boxes of goods, Cargo 20, The cart was loaded with 90 boxes loaded with the truck and the truck was fully loaded and left, time of departure Petr is 15.4.2014 16:00.

# Report

The first part of the program results will be written to the output file, whose name is entered with the third parameter when executing the program (see chapter Running the program).
The output file will contain 3 parts:
1. A list of trucks that have been filled and departing with the time of their departure in the same format as in the input files.
2. List of trucks that have failed to fully load the number of loaded boxes.
3. The number of boxes left after the simulation at the trolley (0 if all was removed).
These individual sections will be separated by lines containing the texts: ODBAVENE_KAMIONY, NEODBAVENE_KAMIONY. The last line of the file will be in the ZUSTATEK_ZBOZI format: the number of boxes. If the data for one of the two parts is not, then it will be left empty, in the demo below, where there are no unpowered trucks:


