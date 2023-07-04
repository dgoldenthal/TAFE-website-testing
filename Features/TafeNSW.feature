Feature: TAFENSW

Feature: Search for a course and apply delivery filter


Scenario: Verify course search and delivery filter functionality

	Given I am on the TAFE NSW website
    When I search for a course with name '<coursename>'
    Then the search results should display the course '<coursename>'
    When I apply the delivery filter as '<filter>'
    Then the filter should be applied correctly to the chosen course '<filter>'

Examples:
          | coursename                      | filter    |
          | Advanced Barista Skills         | On Campus |

          