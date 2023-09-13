#Feature: ManageRequestReceive
#
#As existing user i would like to open recieve request from manage Request and
#Like to accept or decline and view the receive requests.
#
#@tag1
#Scenario:Check any new received request in manage requests then Accept the rquest
#	Given I logged into mars using valid credential
#	When I clicked on manageRequests and choose(click) on receive requests 
#	And I check the status of the request if it is pending i click on Accept
#	Then I should able to see request has been accepted
#@tag1 
#Scenario:Check any new received request in manage requests then Decline the rquest
#	Given I logged into mars using valid credential
#	When I clicked on manageRequests and choose(click) on receive requests 
#	And I check the status of the request if it is pending i click on Decline
#	Then I should able to see request has been Declined
#
