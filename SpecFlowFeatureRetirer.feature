Feature: SpecFlowFeatureRetirer
	Simple calculator for adding two numbers

@retirer
Scenario: Retirer de l argent
	Given leclient suivant
		| nom | prenom | age | numAccount | telephone | solde |
		| Dupont | Alain | 23 | 1215678 | 0696XXXXX | 500 |
	When client retirer 500
	Then ta soeurlesolde du compte est de 0