using System;
using System.Collections.Generic;


//Do not call us , we will call you

//HR department will have  JobPortal

namespace RecuritmentApp
{
    public class Resume{
        public string Name{get;set;}
        public string Email{get;set;}
        public string Content{get;set;}

        public override  string ToString() {
            return "Resume [email=" + Email + ", name=" + Name + ", content=" + Content + "]";
        }
    }

    //Singleton class
    public  class JobPortal{
        private static JobPortal portal=new JobPortal();
        public List<Resume> resumeList=new List<Resume>();
        private  JobPortal(){
        }
        public static JobPortal get(){
            return portal;
        }

        public void uploadContent(string mail, string name, string content){
            Resume resume = new Resume();
            resume.Name=name;
            resume.Email=mail;
            resume.Content=content;
            resumeList.Add(resume);
        }
        public void triggerCampusing(){
            foreach(Resume resume in resumeList)
            {
                 Console.WriteLine("Sending mail to " + resume.Name + " at " + resume.Email);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Tetsing
            //Don't call us , we will call you 
            //
            JobPortal.get().uploadContent("ganesh.shinde@gmail.com", "Ganesh Shinde", "A java developer");
            JobPortal.get().uploadContent("Umesh.sharma@gmail.com", "Umesh Sharma", "A PHP developer");
            JobPortal.get().uploadContent("neha.bhor@gmail.com", "Neha Bhor", "A Microservice developer");
            JobPortal.get().uploadContent("adity.ubale@gmail.com", "Aditya Ubale", "A Network engineer");
            JobPortal.get().uploadContent("mayur.kadam@gmail.com", "Mayur Kadam", "A java Architect");      
            JobPortal.get().triggerCampusing();
        }
    }
}
