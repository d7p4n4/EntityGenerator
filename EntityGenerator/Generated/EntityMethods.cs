using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EntityGenerator
{
    class EntityMethods
    {
        public static PersonBase findFirstById(Int32 id)
        {
            PersonBase p = new PersonBase();

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.id == id)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }
        public static PersonBase findFirstByName(String name)
        {
            PersonBase p = new PersonBase();

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.name == name)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }
        public static PersonBase findFirstByAddress(String address)
        {
            PersonBase p = new PersonBase();

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.address == address)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }
        public static PersonBase findFirstByAge(Int32 age)
        {
            PersonBase p = new PersonBase();

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.age == age)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }
        public static PersonBase findFirstByGender(Boolean gender)
        {
            PersonBase p = new PersonBase();

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.gender == gender)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }
        public static PersonBase findFirstByList(List<String> list)
        {
            PersonBase p = new PersonBase();

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.list == list)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }

        public static IQueryable<PersonBase> findListById(Int32 id)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.id == id);

                p = query;
            }
            return p;
        }
        public static IQueryable<PersonBase> findListByName(String name)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.name == name);

                p = query;
            }
            return p;
        }
        public static IQueryable<PersonBase> findListByAddress(String address)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.address == address);

                p = query;
            }
            return p;
        }
        public static IQueryable<PersonBase> findListByAge(Int32 age)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.age == age);

                p = query;
            }
            return p;
        }
        public static IQueryable<PersonBase> findListByGender(Boolean gender)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.gender == gender);

                p = query;
            }
            return p;
        }
        public static IQueryable<PersonBase> findListByList(List<String> list)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.list == list);

                p = query;
            }
            return p;
        }

    }
}
