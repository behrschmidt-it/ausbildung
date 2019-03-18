
#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	/*
	Bei einem "Tante-Emma-Automaten" sind nur ganzzahlige Beträge zugelassen.
	Erstellen Sie ein Programm, das für einen beliebigen ganzzahligen Betrag (Benutzereingabe) alle möglichen
	Kombinationen aus 1€ , 2€ und 5€ bestimmt.
	*/

	unsigned int betrag;

	cout << "Geben Sie einen ganzzahligen Wunschbetrag ein: ";

	cin >> betrag;

	for (unsigned int i = 0; i <= betrag; i++)
	{
		for (unsigned int j = 0; j <= betrag; j++)
		{
			for (unsigned int k = 0; k <= betrag; k++)
			{
				if ((i * 5)+(j * 2)+(k * 1) == betrag)
				{
					cout << " 5 Euro mal: " << i << endl;
					cout << " 2 Euro mal: " << j << endl;
					cout << " 1 Euro mal: " << k << endl << endl;
				}
			}
		}
	}

}

//cout << "Moegliche Kombination:" << endl;
//cout << i << " mal 5 Euro, sind: " << i * 5 << endl;
//cout << j << " mal 2 Euro, sind: " << j * 2 << endl;
//cout << k << " mal 1 Euro, sind: " << k << endl;