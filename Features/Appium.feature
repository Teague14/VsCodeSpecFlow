Feature: Appium Setup Tests

    As an automation tester
    I want to be able to use Appium
    So I can test on emulators


    Scenario: Initial Appium Test to Launch App
        Given I launch the application
            And I click on the search icon
        When I enter text in the search
        Then results are displayed
