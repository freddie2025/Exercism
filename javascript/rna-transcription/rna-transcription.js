//
// This is only a SKELETON file for the 'RNA Transcription' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const toRna = (letters) => {
  return letters.split('').map(x => (RNA[x])).join("");
};

const RNA = {
  "": "",
  G : "C",
  C : "G",
  T : "A",
  A : "U"
};