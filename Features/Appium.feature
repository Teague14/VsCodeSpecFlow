Feature: Appium Setup Tests

    As an automation tester
    I want to be able to use Appium
    So I can test on emulators

    @test
    Scenario: Initial Appium Test to Launch App
        Given I Click On The Media Item
        When I Click On The MediaPlayer Item
        Then results are displayed
