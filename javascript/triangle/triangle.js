//
// This is only a SKELETON file for the 'Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
  constructor(sideA, sideB, sideC) {
    this.sideA = sideA;
    this.sideB = sideB;
    this.sideC = sideC;
  }

  isEquilateral() {
    return this.isValidTriangle() && this.sideA === this.sideB && this.sideA === this.sideC;
  }

  isIsosceles() {
    return this.isValidTriangle() && this.calculateUniqueSides() <= 2;
  }

  isScalene() {
    return this.isValidTriangle() && this.calculateUniqueSides() === 3;
  }

  isValidTriangle() {
    return this.checkInequality() && this.sideA > 0 && this.sideB > 0 && this.sideC > 0;
  }

  calculateUniqueSides() {
    let sides = new Set();
    sides.add(this.sideA).add(this.sideB).add(this.sideC);
    return sides.size; 
  }

  checkInequality() {
    return (this.sideA + this.sideB) >= this.sideC && (this.sideA + this.sideC) >= this.sideB && (this.sideB + this.sideC) >= this.sideA;
  }

  checkDegenerate() {
    return (this.sideA + this.sideB) == this.sideC || (this.sideA + this.sideC) == this.sideB || (this.sideB + this.sideC) == this.sideA;
  }
}
