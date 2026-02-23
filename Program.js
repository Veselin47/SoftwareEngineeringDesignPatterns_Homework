const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

const vehicleCreators = [
    new CarCreator(),
    new TruckCreator(),
    new MotorcycleCreator()
];

const vehicles = [];

function askQuestion(query) {
    return new Promise(resolve => rl.question(query, resolve));
}

async function main() {
    try {
        for (const creator of vehicleCreators) {

            const vehicleType = splitPascalCaseString(
                creator.constructor.name.replace("Creator", "")
            );

            console.log(`Registering new ${vehicleType}`);

            const model = await askQuestion("Enter model: ");
            const powerInput = await askQuestion("Enter engine power (hp): ");
            const priceInput = await askQuestion("Enter daily rental price: ");

            const power = parseInt(powerInput);
            const price = parseFloat(priceInput);

            if (isNaN(power) || isNaN(price)) {
                throw new TypeError("FormatException");
            }

            const vehicle = creator.createVehicle(model, power, price);
            vehicles.push(vehicle);
            console.log();
        }

        console.log("--- RENTED VEHICLES LIST ---");

        for (const vehicle of vehicles) {
            console.log(vehicle.toString());
        }

        rl.close();

    } catch (exception) {

        if (exception instanceof TypeError) {
            console.log("Aborting! Found entry with wrong format!");
        } else {
            console.log(exception.message);
        }

        rl.close();
    }
}

main();