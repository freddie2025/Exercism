//
// This is only a SKELETON file for the 'Scrabble Score' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const letters = new Map([
  ['a', 1], ['b', 3], ['c', 3], ['d', 2], ['e', 1] ,['f', 4], ['g', 2],
  ['h', 4], ['i', 1], ['j', 8], ['k', 5], ['l', 1], ['m', 3] ,['n', 1], 
  ['o', 1], ['p', 3], ['q', 10], ['r', 1], ['s', 1], ['t', 1] ,['u', 1],
  ['v', 4], ['w', 4], ['x', 8], ['y', 4], ['z', 10]
]);

export const score = (word) => {
  let count = 0;

  word.split('').map(letter => count += letters.get(letter.toLowerCase()));

  return count;
};
