USE master;

USE CoffeeShopDB
GO
INSERT INTO
    Customers(FirstName, LastName, DDOB, MMOB, Race, Email)
VALUES
    (
        'Refilwe',
        'Mashile',
        10,
        12,
        'Black',
        'refilwe@bbd.co.za'
    ),
    ('John', 'Doe', 1, 1, 'White', 'john@bbd.co.za'),
    ('Jane', 'Doe', 22, 4, 'White', 'jane@bbd.co.za');

GO
INSERT INTO
    Baristas(FirstName, LastName)
VALUES
    ('Howard', 'Brown'),
    ('Josh', 'Smith'),
    ('Vusi', 'Nkosi'),
    ('Sihle', 'Ndlovu');

GO
INSERT INTO
    Orders(
        OrderedBy,
        CoffeeName,
        Quantity,
        CoffeePrice,
        OrderAssignee
    )
VALUES
    (1, 'Latte', 3, 25.00, 1),
    (2, 'Cuppuccino', 2, 33.00, 2),
    (3, 'Espresso', 1, 19.00, 3),
    (1, 'Mocha', 1, 22.00, 4)