
#include "pch.h"
#include <iostream>

using namespace std;


int main()
{
	/*
	Ein Brief soll mit Briefmarken im Wert von insgesamt 18 Kopeken frankiert werden. Es stehen beliebig viele Marken mit den Werten 4, 6 und 10 Kopeken zur Verfügung.
	Welche Möglichkeiten gibt es, den Brief ausreichend zu frankieren?

	Folgendew Lösungen fallen sofort auf:

	-	6 + 6 + 6
	-	10 + 4 + 4
	-	6 + 4 + 4 + 4

	Endekriterium:
	Der Brief muss mit Briefmarken im Wert von 18 Kopeken frankiert sein.
	*/

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < 2; k++)
			{
				if (i * 4 + j * 6 + k * 10 == 18)
				{
					cout << "Gefundene Moeglichkeit: " << i << " mal 4, " << j << " mal 6, " << k << " mal 10." << endl;
				}
			}
		}
	}
}
