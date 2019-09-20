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
            PersonBase p = null;

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
            PersonBase p = null;

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
            PersonBase p = null;

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
            PersonBase p = null;

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
            PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.gender == gender)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
            return p;
        }
        public static PersonBase findFirstByList(ICollection<String> list)
        {
            PersonBase p = null;

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
        public static IQueryable<PersonBase> findListByList(ICollection<String> list)
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

	public Boolean existsInPersonBaseById(Int32 id)
	{
		PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.id == id)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
                if(p != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public Boolean existsInPersonBaseByName(String name)
	{
		PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.name == name)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
                if(p != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public Boolean existsInPersonBaseByAddress(String address)
	{
		PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.address == address)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
                if(p != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public Boolean existsInPersonBaseByAge(Int32 age)
	{
		PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.age == age)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
                if(p != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public Boolean existsInPersonBaseByGender(Boolean gender)
	{
		PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.gender == gender)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
                if(p != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public Boolean existsInPersonBaseByList(ICollection<String> list)
	{
		PersonBase p = null;

            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Where(s => s.list == list)
                                .FirstOrDefault<PersonBase>();

                p = query;
            }
                if(p != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

        public static void deleteById(Int32 id)
        {
            using (var ctx = new PersonContext())
            {
                var query = ctx.PersonBases
                                .Remove(ctx.PersonBases.Single(s => s.id == id));

                ctx.SaveChanges();
            }
        }

	public static void addNewPersonBase(PersonBase p)
	{
		using (var ctx = new PersonContext())
            {
                ctx.PersonBases.Add(p);

                ctx.SaveChanges();
            }
	}
    }
}
