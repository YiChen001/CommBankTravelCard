Feature: TravelMoneyCard
	As a customer am able to travel to Travel money card page


Scenario: Navigate to Travel Money Card Page
	Given user launches Commbank page
	When user clicks Travel Products link
	And user clicks Discover more in Travel Money Card section 
	Then user validates subtopics
	And user clicks NetBank 
	And user validates Netbank page opens with username and password fields
	
