
#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	/*
	Ein russischer Bankier zahlt in 8-Rubel- und in 30-Rubel-Stücken aus. Er nimmt kein Wechselgeld zurück.
	Welche Beträge kann er auszahlen?

	Ergänzung:
	Ursprüngliche Aufgabenstellung führt zu einer Endlosschleife, da kein Endekriterium definiert ist.

	Endekriterium: 
	Der Bankier hat 10 13 Rubelscheine, 5 8 Rubelscheine.
	*/

	cout << "Der Bankier kann mit 5 8-Rubel- und 10 13-Rubel-Stuecken folgende Beträge ausgeben: " << endl;

	for (int i = 0; i <= 5; i++)
	{
		for (int j = 0; j <= 10; j++)
		{
			if ((i * 8) + (j * 13) > 0)
			{
				cout << "Anzahl 8-Rubel: " << i << endl;
				cout << "Anzahl 13-Rubel: " << j << endl;
				cout << "Summe:" << (i * 8) + (j * 13) << endl;
			}
		}
	}
}