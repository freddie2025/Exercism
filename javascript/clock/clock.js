//
// This is only a SKELETON file for the 'Clock' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Clock {
  constructor(hours = 0, minutes = 0) {
    this.hours = hours;
    this.minutes = minutes;
    this.date = this.setDate();
  }

  setDate() {
    let date = new Date(Date.UTC(2020, 1, 1, 0, 0, 0));
    date.setUTCHours(this.hours);
    date.setUTCMinutes(this.minutes);
    return date;
  }

  toString() {
    return this.date.toTimeString().substring(0, 5);
  }

  plus(minutes) {
    this.date.setUTCMinutes(this.minutes + minutes);
    return this;
  }

  minus(minutes) {
    this.date.setUTCMinutes(this.minutes - minutes);
    return this;
  }

  equals(clock) {
    return this.toString() === clock.toString();
  }
}
