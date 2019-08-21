export default class Parking {
    constructor(
        public id: number,
        public name: string,
        public description: string,
        public isOpen: boolean,
        public availableCapacity: number,
        public totalCapacity: number,
        public address: string
    ){}

    toString(){
        return `${this.name} - ${this.availableCapacity} / ${this.totalCapacity}`;
    }
}
