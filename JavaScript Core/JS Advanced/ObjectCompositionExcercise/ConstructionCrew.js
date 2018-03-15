function calcBloodAlcoholLevel (obj) {
    if (obj.handsShaking == true) {
        obj.bloodAlcoholLevel += (obj.experience * obj.weight )*0.1
        obj.handsShaking = false
    }
    return obj
}

let worker = calcBloodAlcoholLevel({ weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true }
);

console.log(worker)
