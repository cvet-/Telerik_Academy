function Person(firstName, lastName, age) {
    
    if (!this instanceof Person) {
        return new Person(firstName, lastName, age);
    }

    this.firstname = firstName;
    this.lastname = lastName;
    this.age = age;
}

function findYoungestPerson(array) {
   
    var i,
        youngest = new Person('', '', Number.MAX_VALUE);

    for (i = 0; i < array.length; i += 1) {
        if (array[i] instanceof Person) {
            if (array[i].age < youngest.age) {
                youngest.firstname = array[i].firstname;
                youngest.lastname = array[i].lastname;
                youngest.age = array[i].age;
            }
        }
    }

    if (youngest.firstname === '') {
        return 'Not found';
    } else {
        return youngest.firstname + ' ' + youngest.lastname;
    }
}

function problem5() {
    
    var people = [
        new Person('Cosima', 'Niehaus', 21),
        new Person('Sarah', 'Manning', 26),
        new Person('Alison', 'Hendrix', 32),
        new Person('Delphine', 'Cormier', 14)];

    alert('The youngest person is: ' + findYoungestPerson(people));
}