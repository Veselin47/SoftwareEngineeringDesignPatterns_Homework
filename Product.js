class Vehicle {
    static MIN_POWER = 35;
    static MAX_POWER = 2000;
    static MIN_PRICE = 50;
    static MAX_PRICE = 10000;

    constructor(model, enginePower, dailyPrice) {
        this.model = model;
        this.enginePower = enginePower;
        this.dailyPrice = dailyPrice;
    }

    get model() {
        return this._model;
    }

    set model(value) {
        if (!value || value.trim() === "") {
            throw new Error(`The ${splitPascalCaseString(this.constructor.name)}'s model cannot be empty!`);
        }
        this._model = value;
    }

    get enginePower() {
        return this._enginePower;
    }

    set enginePower(value) {
        if (value < Vehicle.MIN_POWER || value > Vehicle.MAX_POWER) {
            throw new Error(`Engine power must be between ${Vehicle.MIN_POWER} and ${Vehicle.MAX_POWER} hp!`);
        }
        this._enginePower = value;
    }

    get dailyPrice() {
        return this._dailyPrice;
    }

    set dailyPrice(value) {
        if (value < Vehicle.MIN_PRICE || value > Vehicle.MAX_PRICE) {
            throw new Error(`The ${splitPascalCaseString(this.constructor.name)}'s daily price must be between ${Vehicle.MIN_PRICE} and ${Vehicle.MAX_PRICE}!`);
        }
        this._dailyPrice = value;
    }

    toString() {
        return `Vehicle Type: ${splitPascalCaseString(this.constructor.name)} | Model: ${this.model} | Power: ${this.enginePower}hp | Price: ${this.dailyPrice} лв/day`;
    }
}

class Car extends Vehicle {}
class Truck extends Vehicle {}
class Motorcycle extends Vehicle {}
