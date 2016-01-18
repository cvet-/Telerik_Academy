function Person(firstName, lastName, age) {
    if (!this instanceof Person) {
        return new Person(firstName, lastName, age);
    }
    this.firstname = firstName;
    this.lastname = lastName;
    this.age = age;
}
function groupPeople(array, key) {
    var result = [],
        i;

    switch (key) {
        case 'firstname':
            for (i = 0; i < array.length; i += 1) {
                result.push(array[i].firstname);
            }
            return result;
        case 'lastname':
            for (i = 0; i < array.length; i += 1) {
                result.push(array[i].lastname);
            }
            return result;
        case 'age':
            for (i = 0; i < array.length; i += 1) {
                result.push(array[i].age);
            }
            return result;
        default:
            return result;
    }
}
function problem6() {

    var people = [
        new Person('Cosima', 'Niehaus', 21),
        new Person('Sarah', 'Manning', 26),
        new Person('Alison', 'Hendrix', 32),
        new Person('Delphine', 'Cormier', 14)];

    alert('First names: ' + groupPeople(people, 'firstname'));
    alert('Last names: ' + groupPeople(people, 'lastname'));
    alert('Ages: ' + groupPeople(people, 'age'));
}