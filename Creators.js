class CarCreator {
    createVehicle(model, enginePower, dailyPrice) {
        return new Car(model, enginePower, dailyPrice);
    }
}

class TruckCreator {
    createVehicle(model, enginePower, dailyPrice) {
        return new Truck(model, enginePower, dailyPrice);
    }
}

class MotorcycleCreator {
    createVehicle(model, enginePower, dailyPrice) {
        return new Motorcycle(model, enginePower, dailyPrice);
    }
}