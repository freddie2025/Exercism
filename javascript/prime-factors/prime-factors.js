//
// This is only a SKELETON file for the 'Prime Factors' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const primeFactors = (number) => {
  let list = [];
  let division = 2;

  do
  {
      if(number % division == 0)
      {
          list.push(division);
          number = number / division;
          division = 2; 
      } 
      else division++;                
  } 
  while (number > 1);

  return list;
};
