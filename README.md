# Megaprimes Utility
Finds the Megaprimes of given maximum integer value

# Aim / Objectives
- Write a function to identify the collection of megaprime numbers given a
maximum integer value.
- Observe the functional requirements as outlined. 

# Decisions
- A minimum viable product (MVP) approach was chosen due to time constraints. 
  - The small appication uses a layered Onion Architecture so that it can be easily scaled and is API ready. The different supporting services such as `PrimeService`, `MegaPrimeService` and `ComputeMegaPrimesService` are all loosely coupled. 
- The `ComputeMegaPrimes` mmethod on the `ComputeMegaPrimesService` service uses a recursive approach. This was favoured due to readability and succinct code. However, if future load testing proves this to be non-optimal, the functionality can be easily converted to a non-recursive version.

``` c#
        private void ComputeMegaPrimes(int maximumValue)
        {
            if (maximumValue < 2)
            {
                return;
            }

            ...

            maximumValue--;

            ComputeMegaPrimes(maximumValue);
        }
```

# Standards used
- Onion Layered Application Architecture
- Test Driven Development for the critical paths

# Notes

- There is a number of improvements that were considered and concluded as over kill at this stage. The application cen be easily extended to bring them in at an appropriate stage.
  - Dependency Injection
  - Global error handling
  - Expose the functionality as a REST service
  - Containerise the application

