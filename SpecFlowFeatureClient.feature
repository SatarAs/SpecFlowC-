Feature: SpecFlowFeatureClient
	Organisation et gestion de l'ensemble des comptes

@consulter
Scenario: Consulter du solde
	Given sclient suivant
		| nom    | prenom | age | numClient | telephone | solde |
		| Dupont | Alain  | 23  | 1215678    | 0696XXXXX | 1000  |
	When ce client est sélectionné
	Then solde du compte est de 1000