-- Table Creation
CREATE TABLE menu_combinations (
    id UUID PRIMARY KEY NOT NULL,
    item_name VARCHAR(50) NOT NULL,
    price NUMERIC(10, 2) NOT NULL
);

-- Insert Statements with UUID version 4
INSERT INTO menu_combinations (id, item_name, price) VALUES 
    (uuid_generate_v4(), 'Chicken & Shrimp', 63.00),
    (uuid_generate_v4(), 'NY Steak & Chicken', 66.00),
    (uuid_generate_v4(), 'NY Steak & Shrimp', 68.00),
    (uuid_generate_v4(), 'NY Steak, Chicken & Shrimp', 75.00),
    (uuid_generate_v4(), 'NY Steak & Lobster', 80.00),
    (uuid_generate_v4(), 'Fillet Mignon 6oz', 67.00),
    (uuid_generate_v4(), 'Fillet Mignon & Shrimp', 74.00),
    (uuid_generate_v4(), 'Fillet Mignon & Scallops', 77.00),
    (uuid_generate_v4(), 'Fillet Mignon & Lobster', 84.00),
    (uuid_generate_v4(), 'Fillet Mignon & Salmon', 76.00),
    (uuid_generate_v4(), 'Fillet Mignon, Chicken & Shrimp', 80.00),
    (uuid_generate_v4(), 'Rib Eye Sumo 12oz', 78.00),
    (uuid_generate_v4(), 'Rib Eye & Shrimp', 80.00),
    (uuid_generate_v4(), 'Rib Eye & Scallops', 82.00),
    (uuid_generate_v4(), 'Rib Eye & Lobster', 85.00),
    (uuid_generate_v4(), 'Kanji (NY Steak, Lobster & Shrimp)', 87.00),
    (uuid_generate_v4(), 'Chefs Special (Fillet Mignon, Lobster & Shrimp)', 104.00),
    (uuid_generate_v4(), 'Genki (Fillet Mignon, Lobster Tail & Scallops)', 115.00),
    (uuid_generate_v4(), 'Hibachi Deluxe (Japanese A5 Wagyu & Lobster)', 195.00),
    (uuid_generate_v4(), 'Hibachi Vegetarian', 52.00);
