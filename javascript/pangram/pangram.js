//
// This is only a SKELETON file for the 'Pangram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isPangram = (input) => {
  let letters = new Set(['a','b','c','d','e','f','g','h','i','j','k','m','n','l','o','p','q','r','s','t','u','v','w','x','y','z']);

  for (let i = 0; i < input.length; i++) {

    const letter = input.charAt(i).toLowerCase(); 
    
    letters.delete(letter);
  }

  return letters.size == 0;
};

