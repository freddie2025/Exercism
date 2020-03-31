//
// This is only a SKELETON file for the 'Meetup' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const schedules = {
  'teenth': 13,
  '1st': 1,
  '2nd': 8,
  '3rd': 15,
  '4th': 22,
  '5th': 29,
  'last': 0
}

const daysOfWeek = {
  Sunday: 0,
  Monday: 1,
  Tuesday: 2,
  Wednesday: 3,
  Thursday: 4,
  Friday: 5,
  Saturday: 6
}

export const meetupDay = (year, month, dayOfWeek, schedule) =>  {

  let daysInMonth = new Date(year, month +1, 0).getDate();
  let dayOfMonth = 1;

  if (daysInMonth === 28 && new Date(year, month, 1).getDay() === 0 && schedule === '5th') {
    throw `${month} ${year} does not contain a 5th week.`;
  }

  if(schedule === 'last') {
      for (let day = daysInMonth; day >= 1; day--) {
          if(new Date(year, month, day).getDay() == daysOfWeek[dayOfWeek]) {
              dayOfMonth = day;
              break;
          }
      }
  }
  else {
      for (let day = schedules[schedule]; day <= daysInMonth; day++) {
          if(new Date(year, month, day).getDay() == daysOfWeek[dayOfWeek]) {
              dayOfMonth = day;
              break;
          }
      }
  }
  
  return new Date(year, month, dayOfMonth);
}
