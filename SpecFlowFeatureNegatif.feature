Feature: SpecFlowFeatureNegatif
	Solde Negatif

@mytag
Scenario: Operer solde negatif
	Given client suivant
		| nom | prenom | age | numAccount | telephone | solde |
		| Dupont | Alain | 23 | 1215678 | 0696XXXXX | 500.0 |
	When client retire 700.0
	Then la transaction est refusee