# Simple Ordering System for a Bookstore

Implementing a simple ordering system for a bookstore that sells books and magazines as a console application.
Selling subscriptions for magazines should also be an option.

## Class Hierarchy

1. **Base Class: Book**
   - Properties:
     - `Isbn`
     - `Name`
     - `Publisher`
     - `Price`
   - Fundamental Methods:
     - Constructor
     - Overloaded `ToString`
     - Basic input method: `Read`

2. **Derived Class: Magazine**
   - Additional Property:
     - `PublicationPeriod`: Daily, Weekly, Monthly (use an enumeration)
   - Provide overloads for the base methods.

### Testing
- Create two books and two magazines.
- (For extra points) Allow additional books/magazines to be entered from the main menu.

## Generic Class

- Create a generic class `Order<T>` where `T` is the type of item being ordered (in this case, a book or a magazine).
  - Properties:
    - `Id` (unique sequence number)
    - `Item T`
    - `OrderDate`
    - `Quantity` (ordered)
    - If applicable: `SubscriptionPeriod` (for magazine subscriptions)
  - Method: `Tuple Order()` (see details below)

## Personalized Get/Set

- Use getters and setters to ensure:
  - The price of a book is always between €5 and €50.
  - Assign a unique sequence number to the order ID.

## Tuple

- When a book is ordered, return a Tuple containing:
  - ISBN of the book
  - Number of ordered copies
  - Total price

## Events

- When a book is ordered, trigger an event with a simple message confirming the order.
- 
