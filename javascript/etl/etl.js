//
// This is only a SKELETON file for the 'etl' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const transform = (input) => {
  let map = new Map();

  for (let key in input) {
    let value = input[key];
    for (let i = 0; i < value.length; i++) {
      map.set(value[i].toLowerCase(), parseInt(key));
    }
  }

  return Object.fromEntries(map);
};
