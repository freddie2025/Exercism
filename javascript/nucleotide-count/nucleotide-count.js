//
// This is only a SKELETON file for the 'Nucleotide-Count' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class NucleotideCounts {
  static parse(strand) {

    let aCount = 0, cCount = 0, gCount = 0, tCount = 0;

    for (var i = 0; i < strand.length; i++) {
      switch (strand.charAt(i).toUpperCase()) {
        case 'A' : 
          aCount++;
          break;
        case 'C' :
          cCount++;
          break;
        case 'G' :
          gCount++;
          break;
        case 'T' :
          tCount++;
          break;
        default:
          throw new Error('Invalid nucleotide in strand');
      }
    }
    return `${aCount} ${cCount} ${gCount} ${tCount}`;
  }
}
