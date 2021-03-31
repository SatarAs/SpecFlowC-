Feature: SpecFlowFeatureDeposer
	Simple calculator for adding two numbers	
	
@deposer
Scenario: Deposer de l argent
	Given le client suivant
		| nom | prenom | age | numAccount | telephone | solde |
		| Dupont | Alain | 23 | 1215678 | 0696XXXXX | 0.0 |
	When ce client depose 1000
	Then tasoeurlesolde du compte est de 1000.0