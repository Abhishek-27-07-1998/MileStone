Feature: SpecFlowFeature1
	Dove Application automation

@Search
Scenario: SearchFeature
	Given Load the URL
	And Click on search
	When You enter Shampoo
	Then the result should display Shampoo

@Discovermore
Scenario: DiscoverMore
	Given Open the URL
	When You click on dicover more
	Then Verify the text

@Termsofuse
Scenario: TermsofuseinFooter
	Given Open the Link
	When Ypu click on TermsofUse
	Then Verify the text ProhibitedUse